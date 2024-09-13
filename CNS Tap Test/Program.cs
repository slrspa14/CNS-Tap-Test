using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;


namespace CNS_Tap_Test
{
    internal static class Program
    {
        private static Mutex mutex = null;
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string processName = Process.GetCurrentProcess().ProcessName;
            if(IsExistProcessMutex(processName))
            {
                MessageBox.Show("프로그램이 이미 실행중입니다.");
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new StartPage());
            }
            
        }
        private static bool IsExistProcessMutex(string processName)
        {
            mutex = new Mutex(true, processName, out bool createdNew);
            if (createdNew)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
