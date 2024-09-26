using IWshRuntimeLibrary;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CNS_Tap_Test
{
    public partial class StartPage : Form
    {
        //바로가기
        public static bool isClosing = false;
        private static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        DirectoryInfo Desktop = new DirectoryInfo(DesktopPath);
        private static string LinkFileName = DesktopPath.ToString() + @"\Tap_Test 바로가기.lnk";
        FileInfo LinkFile = new FileInfo(LinkFileName);

        //db 객체 생성 및 db 열기
        DataBase DB = new DataBase();

        public StartPage()
        {
            //버튼이 없어도 되나
            //picturebox 클릭했을 때 이벤트를 등록해서 다음 페이지로 넘어가게만 하게
            InitializeComponent();
            CenterToScreen();
            //start_btn.FlatStyle = FlatStyle.Flat;
            //start_btn.FlatAppearance.BorderSize = 0;
            //start_btn.BackColor = Color.Transparent;
            //start_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            //start_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            //GotoIcon();
            start_picbox.Load(@"D:\CNS_Tap\Library\CNS Tap Test\CNS Tap Test\logo.png");
            start_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            start_picbox.Click += new EventHandler(MovePage);
            DB.OpenDB();
            DB.CreateTable();
        }
        private void MovePage(object sender, EventArgs e)
        {
            MenuPage menuPage = new MenuPage(this);
            this.Hide();
            menuPage.Show();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            //if(MessageBox.Show("종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            if (!isClosing)
            {
                if (MessageBox.Show("종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    isClosing = true;
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        //private void GotoIcon()
        //{
        //    if (LinkFile.Exists)
        //    {
        //        return;
        //    }
        //    try
        //    {
        //        //바로가기 생성
        //        WshShell wshShell = new WshShell();
        //        IWshShortcut Link = wshShell.CreateShortcut(LinkFile.FullName);

        //        //원본 파일 경로
        //        StringBuilder originPath = new StringBuilder();
        //        originPath.Append(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
        //        originPath.Append(@"\CNS Tap Test.exe");
        //        Link.TargetPath = originPath.ToString();
        //        Link.Save();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
