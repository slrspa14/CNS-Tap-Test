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
        private DateTime now = DateTime.Now;
        public Graph()
        {
            InitializeComponent();
            OpenDB();
            CreateTable();

        }
        public void Visualization(string tapCount)
        {
            try
            {
                InsertTapData(now, tapCount);
                string test = SelectTapData();
                textBox1.Text = test;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void InsertTapData(DateTime Daily, string tap)
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
            mQuery = "CREATE TABLE IF NOT EXISTS RECORD(date DATETIME, dayRecord STRING)";
            using(SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB))
            {
                command.ExecuteNonQuery();
            }
        }
        private string SelectTapData()
        {
            StringBuilder record = new StringBuilder();
            mQuery = "SELECT dayRecord FROM RECORD";
            using(SQLiteCommand command = new SQLiteCommand(mQuery, mConnectDB))
            {
                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        record.Append($"{reader}\n");
                    }
                }
                return record.ToString();
            }
        }
        private void OpenDB()
        {
            mConnectDB.Open();
        }
    }

}
