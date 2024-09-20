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
    public partial class LogINPage : Form
    {
        //ID, PW 일치 불일치 확인
        //디자인
        
        public LogINPage()
        {
            InitializeComponent();
        }

        private void LogINPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
