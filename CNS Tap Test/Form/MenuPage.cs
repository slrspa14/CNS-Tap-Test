using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNS_Tap_Test
{
    public partial class MenuPage : Form
    {
        //로그인, 회원가입 선택 메뉴
        //크기
        //디자인은 어떻게 하지
        private Form parentForm;

        
        public MenuPage(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            //회원가입
            JoinPage joinPage = new JoinPage(parentForm);
            this.Hide();
            joinPage.Show();
            
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            //로그인
            LogINPage logINPage = new LogINPage();
            this.Hide();
            logINPage.Show();
        }

        private void MenuPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!StartPage.isClosing)
            {
                if (MessageBox.Show("종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StartPage.isClosing = true;
                    parentForm.Close(); // 부모 폼도 함께 종료
                }
                else
                {
                    e.Cancel = true;
                }
            }
            
        }
    }
}
