using System;
using System.IO;
using System.Windows.Forms;

namespace ClearCore.Cleaner
{
    public partial class CleanerForm : Form
    {
        public CleanerForm()
        {
            InitializeComponent();
        }
        public CleanerManager clearManager = null;
        private void CleanerForm_Load(object sender, EventArgs e)
        {
            clearManager = new CleanerManager(this);
            clearManager.OnLoadDone = () =>
            {
                clearManager.UpdateUI();
            };
        }
        private async void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                timer1.Stop();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                xuiCircleProgressBar1.Visible = true;
                NotificationManager.Manager notificationManager = new NotificationManager.Manager();
                long cleared = await clearManager.Clear();
                if (cleared > 0)
                {
                    notificationManager.Alert("Очищено: " + clearManager.BytesToString(cleared), NotificationManager.NotificationType.Success);
                }
                else
                {
                    notificationManager.Alert("Нечего чистить", NotificationManager.NotificationType.Error);
                }

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                timer1.Start();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                clearManager.UpdateCheckedUI();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearManager.ClearDataBase();
            clearManager = new CleanerManager(this);
            clearManager.OnLoadDone = () =>
            {
                clearManager.UpdateUI();
            };
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string path = "Export.cs";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                string responce = wc.DownloadString(CleanerManager.DataBaseURL);
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(responce);
                }
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "C# Script(*.cs)|*.cs";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            clearManager.LoadCustom(new PluginsAPI.Script(filename));

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            xuiCircleProgressBar1.Visible = false;
        }


    }
}
