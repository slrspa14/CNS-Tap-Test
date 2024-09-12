using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using IWshRuntimeLibrary;

namespace CNS_Tap_Test
{
    public partial class Graph : Form
    {
        //하루에 몇 번 할 수도 있으니깐 시간은 년월일 시분초까지 저장하기
        //일별 주간별 월별 데이터 시각화 //시간별은 애매 //월요일에 일별 띄우고 // 1일엔 월별 띄우기
        // 경로
        private static string DBpath = "../../TapTestData.db";
        private SQLiteConnection mConnectDB = new SQLiteConnection($"Data Source = {DBpath};Version = 3");
        private string mQuery;
        private DateTime mNow = DateTime.Now;

        //바로가기
        private static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        DirectoryInfo Desktop = new DirectoryInfo(DesktopPath);
        private static string LinkFileName = DesktopPath.ToString() + @"\Tap_Test 바로가기.lnk";
        FileInfo LinkFile = new FileInfo(LinkFileName);

        
        public Graph()
        {
            InitializeComponent();
            GotoIcon();
            OpenDB();
            CreateTable();
        }
        public void Visualization(string tapCount)
        {
            try
            {
                InsertTapData(mNow.ToString("F"), tapCount);
                string test = SelectTapData();
                textBox1.Text = test;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void InsertTapData(string Daily, string tap)
        {
            mQuery = "INSERT INTO RECORD(date, dayRecord) VALUES(@Daily, @tap)";
            using(SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB)) 
            {
                command.Parameters.AddWithValue("@Daily", Daily);
                command.Parameters.AddWithValue(@"tap", tap);
                command.ExecuteNonQuery();
            }
        }
        private void CreateTable()
        {
            mQuery = "CREATE TABLE IF NOT EXISTS RECORD(date STRING, dayRecord STRING)";
            using(SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB))
            {
                command.ExecuteNonQuery();
            }
        }
        private string SelectTapData()
        {
            StringBuilder record = new StringBuilder();
            mQuery = "SELECT dayRecord FROM RECORD";
            using (SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        record.AppendLine($"{reader["dayRecord"]}");
                    }
                }
                return record.ToString();
            }
            
        }
        
        private void OpenDB()
        {
            mConnectDB.Open();
        }

        private void GotoIcon()
        {
            if(LinkFile.Exists)
            {
                return;
            }
            try
            {
                //바로가기 생성
                WshShell wshShell = new WshShell();
                IWshShortcut Link = wshShell.CreateShortcut(LinkFile.FullName);

                //원본 파일 경로
                StringBuilder originPath = new StringBuilder();
                originPath.Append(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
                originPath.Append(@"\CNS Tap Test.exe");
                Link.TargetPath = originPath.ToString();
                Link.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
