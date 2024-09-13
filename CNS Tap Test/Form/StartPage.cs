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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            //버튼이 없어도 되나
            //picturebox 클릭했을 때 이벤트를 등록해서 다음 페이지로 넘어가게만 하게
            InitializeComponent();
            //start_btn.FlatStyle = FlatStyle.Flat;
            //start_btn.FlatAppearance.BorderSize = 0;
            //start_btn.BackColor = Color.Transparent;
            //start_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            //start_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            start_picbox.Load(@"C:\Users\user\Desktop\logo.png");
            start_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            start_picbox.Click += new EventHandler(MovePage);
        }
        private void MovePage(object sender, EventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            this.Hide();
            menuPage.Show();
        }
    }
}
