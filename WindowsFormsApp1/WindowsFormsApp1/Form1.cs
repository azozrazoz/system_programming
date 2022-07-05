using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SecondsInTime_Click(object sender, EventArgs e)
        {
            var currentUser = Registry.CurrentUser;
            var subKey = currentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
            subKey.SetValue("ShowSecondsInSystemClock", "1", RegistryValueKind.DWord);
            subKey.Close();
            RestartExplore();
        }

        private void DefaultTime_Click(object sender, EventArgs e)
        {
            var currentUser = Registry.CurrentUser;
            var subKey = currentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
            subKey.SetValue("ShowSecondsInSystemClock", "0", RegistryValueKind.DWord);
            subKey.Close();
            RestartExplore();
        }

        private static void RestartExplore()
        {
            /*foreach (Process p in Process.GetProcesses())
            {
                if (p.MainModule.ModuleName.Contains("explorer") == true)
                    p.Kill();
            }
            string explorer = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe");
            Process process = new Process();
            process.StartInfo.FileName = explorer;
            process.StartInfo.UseShellExecute = true;
            process.Start();*/

            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"C:\Users\itstart.ITSTEP\Documents\script.bat";

            myProcess.Start();
        }
    }
}
