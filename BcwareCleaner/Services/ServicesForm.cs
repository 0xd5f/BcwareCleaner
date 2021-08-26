using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BcwareCleaner
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }
        private void ServicesForm_Load(object sender, EventArgs e)
        {
            /* Проверка гибернаций */
            BcwareCleaner.Services.GybernateClass gybernate = new BcwareCleaner.Services.GybernateClass();
            Task.Factory.StartNew(() =>
            {
                bool on = gybernate.Activated();
                flatLabel1.Invoke(new MethodInvoker(() =>
                {
                    flatLabel1.Text = ("Режим гибернации " + !on);
                }));
            });
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.LocalMachine;
            RegistryKey windowsdefender = reg.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            windowsdefender.SetValue("DisableAntiSpyware", 0);
            timer1.Enabled = true;
            flatStatusBar1.Text = "Защитник Windows включен";
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.LocalMachine;
            RegistryKey windowsdefender = reg.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            windowsdefender.SetValue("DisableAntiSpyware", 1);
            timer1.Enabled = true;
            flatStatusBar1.Text = "Защитник Windows отключен";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flatStatusBar1.Text = "Status";
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
            ServiceController windowsupdater = new ServiceController("Центр обновления Windows");
            Services.ServiceHelper.ChangeStartMode(windowsupdater, ServiceStartMode.Disabled);
            if (windowsupdater.Status != ServiceControllerStatus.Stopped)
            windowsupdater.Stop();
            });
            timer1.Enabled = true;
            flatStatusBar1.Text = "Обновления Windows отключены";
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
            ServiceController windowsupdater = new ServiceController("Центр обновления Windows");
            Services.ServiceHelper.ChangeStartMode(windowsupdater, ServiceStartMode.Automatic);
            if (windowsupdater.Status != ServiceControllerStatus.StartPending)
            windowsupdater.Start();
            });
            timer1.Enabled = true;
            flatStatusBar1.Text = "Обновления Windows включены";
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                BcwareCleaner.Services.GybernateClass gybernate = new BcwareCleaner.Services.GybernateClass();
                gybernate.Enable(true);
            });
            timer1.Enabled = true;
            flatStatusBar1.Text = "Режим гибернации включен";
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                BcwareCleaner.Services.GybernateClass gybernate = new BcwareCleaner.Services.GybernateClass();
                gybernate.Enable(false);
            });
            timer1.Enabled = true;
            flatStatusBar1.Text = "Режим гибернации отключен";
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.LocalMachine;
            RegistryKey chromeblock = reg.OpenSubKey(@"SOFTWARE\Policies\Google\Chrome", true);
            chromeblock.SetValue("DownloadRestrictions", 3);
            timer1.Enabled = true;
            flatStatusBar1.Text = "Загрузки Chrome заблокированы";
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.LocalMachine;
            RegistryKey chromeblock = reg.OpenSubKey(@"SOFTWARE\Policies\Google\Chrome", true);
            chromeblock.SetValue("DownloadRestrictions", 0);
            timer1.Enabled = true;
            flatStatusBar1.Text = "Загрузки Chrome разблокированы";
        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.LocalMachine;
            RegistryKey disklock = reg.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", true);
            disklock.DeleteValue("NoDrives");
            string strCmdText;
            strCmdText = "/c taskkill /f /im explorer.exe";
            System.Diagnostics.Process.Start("cmd.exe", strCmdText);
            System.Threading.Thread.Sleep(500);
            Process.Start(Environment.SystemDirectory + "\\..\\explorer.exe");
            timer1.Enabled = true;
            flatStatusBar1.Text = "Диски разблокированы";
        }

        private void flatButton9_Click(object sender, EventArgs e)
        {    
            RegistryKey reg = Registry.LocalMachine;
            RegistryKey disklock = reg.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", true);
            disklock.SetValue("NoDrives", 31);
            string strCmdText;
            strCmdText = "/c taskkill /f /im explorer.exe";
            System.Diagnostics.Process.Start("cmd.exe", strCmdText);
            System.Threading.Thread.Sleep(500);
            Process.Start(Environment.SystemDirectory + "\\..\\explorer.exe");
            timer1.Enabled = true;
            flatStatusBar1.Text = "Диски заблокированы";
        }
    }
}
