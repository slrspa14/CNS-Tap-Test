using System;
using System.Windows.Forms;

namespace CNS_Tap_Test
{
    //회원가입, 로그인 기능 업데이트하기 나중에
    public partial class TapTest : Form
    {
        private int click = 0;
        private int setTime = 10;
        private Graph graphForm = new Graph();
        public TapTest()
        {
            InitializeComponent();
        }

        private void btnTap_Click(object sender, EventArgs e)
        {
            //누르기 시작하면 10초 카운트
            //Tap 횟수 기록해서 그래프 시각화
            //Tap 횟수 매일매일 저장 및 불러와서 그래프 시각화
            //10초가 지나면 화면전환 -> 결과 폼이 따로
            //데이터는 DB에 저장,
            lblResult.Text = "중추신경: " + ++click;
            timeTen.Interval = 1000;
            timeTen.Enabled = true;
            //10초 지나면 graph.Show();

        }

        private void timeTen_Tick(object sender, EventArgs e)
        {
            //timer 10초로 설정하고 10초 경과시 탭 데이터 전송 폼 전환
            
            if(setTime > 1)
            {
                setTime--;
                lblTimeLimit.Text = setTime.ToString();
            }
            else
            {
                timeTen.Enabled = false;
                this.Visible = false;
                graphForm.Visualization(click.ToString());
                graphForm.ShowDialog();
            }    
        }
    }
}
