using System;
using System.Windows.Forms;

namespace CNS_Tap_Test
{


    public partial class ResultGraph : Form
    {
        //하루에 몇 번 할 수도 있으니깐 시간은 년월일 시분초까지 저장하기
        //일별 주간별 월별 데이터 시각화 //시간별은 애매 //월요일에 일별 띄우고 // 1일엔 월별 띄우기
        //시각화 UI에 버튼 추가하기 최고 기록, 최저 기록? 클릭시 날짜별로 최고점 최저점 확인할 수 있게 // 필요한가? // 없다면 로그인 해서 하루에 한 번만 가능하게 하기?
        //
        //그래프 어떤걸로 할 건지 막대기인지 선인지

        // 경로
        //static string DBpath = "../../TapTestData.db";
        //static SQLiteConnection mConnectDB = new SQLiteConnection($"Data Source = {DBpath};Version = 3");
        //private string mQuery;

        private DateTime mNow = DateTime.Now;
        DataBase mDB = new DataBase();
        public ResultGraph()
        {
            InitializeComponent();
            
        }
        public void Visualization(string tapCount)
        {
            try
            {
                mDB.InsertTapData(mNow.ToString("F"), tapCount);
                string test = mDB.SelectTapData();
                textBox1.Text = test;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
