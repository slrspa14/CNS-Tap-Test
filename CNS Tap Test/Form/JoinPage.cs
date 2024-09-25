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
    public partial class JoinPage : Form
    {
        //중복 확인
        //디자인
        private Form parentForm;
        private string mGIFPath = "../test.gif";
        public JoinPage(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            join_page_image.Image = Image.FromFile(mGIFPath);

        }
        

        private void JoinPage_FormClosing(object sender, FormClosingEventArgs e)
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
        //send 버튼 이벤트
        //중복 확인 함수
        //ID만 확인할까 PW도 같이 확인할까
        //
    }
}
