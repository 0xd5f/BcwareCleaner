using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.ServiceProcess;
using Microsoft.Win32;
using System.Threading.Tasks;

namespace ClearCore
{
    public partial class MainMenu : Form
    {
        public ColorConverter colorConverter = new ColorConverter();
        public MainMenu()
        {
            InitializeComponent();
            OpenChildForm(cleaner, false);
        }
        private Form currentChildForm;
        private string currentChildFormname;
        public void OpenChildForm(Form childForm, bool newform = false)
        {
            if (currentChildForm != childForm && currentChildFormname != childForm.Name)
            {
                if (currentChildForm != null)
                {
                    if (newform)
                    {
                        currentChildForm.Close();
                    }
                    panelDesktop.Controls.Clear();
                }
                currentChildForm = childForm;
                currentChildFormname = childForm.Name;
                childForm.BackColor = panelDesktop.BackColor;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        public Cleaner.CleanerForm cleaner = new Cleaner.CleanerForm();
        public Optimize.OptimizeForm optimize = new Optimize.OptimizeForm();
        public BcwareCleaner.ServicesForm services = new BcwareCleaner.ServicesForm();
        public ColorEditForm colorEdit = new ColorEditForm();
        public ThemeManager themeManager = new ThemeManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }


        private void xuiButton1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(cleaner, false);
        }

        private void xuiButton4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(optimize, false);
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/OxD5F");
        }


        private void flatButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(services, false);
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/0xd5f");
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            Process.Start(" https://lolz.guru/oxd5f");
        }
    }
}
