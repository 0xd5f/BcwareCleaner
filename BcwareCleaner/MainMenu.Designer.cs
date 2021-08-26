
namespace ClearCore
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.formSkin1 = new FlatUI.FormSkin();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flatButton5 = new FlatUI.FlatButton();
            this.lv = new FlatUI.FlatLabel();
            this.cv = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton4 = new FlatUI.FlatButton();
            this.flatStatusBar1 = new FlatUI.FlatStatusBar();
            this.xuiButton4 = new FlatUI.FlatButton();
            this.xuiButton1 = new FlatUI.FlatButton();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.flatButton6 = new FlatUI.FlatButton();
            this.formSkin1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.panel2);
            this.formSkin1.Controls.Add(this.panel1);
            this.formSkin1.Controls.Add(this.flatButton4);
            this.formSkin1.Controls.Add(this.flatStatusBar1);
            this.formSkin1.Controls.Add(this.xuiButton4);
            this.formSkin1.Controls.Add(this.xuiButton1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.panelDesktop);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(680, 478);
            this.formSkin1.TabIndex = 13;
            this.formSkin1.Text = "Bcware Cleaner";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.flatButton5);
            this.panel2.Controls.Add(this.lv);
            this.panel2.Controls.Add(this.cv);
            this.panel2.Controls.Add(this.flatLabel2);
            this.panel2.Location = new System.Drawing.Point(5, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 79);
            this.panel2.TabIndex = 28;
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.Transparent;
            this.flatButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            this.flatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton5.Location = new System.Drawing.Point(6, 53);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Rounded = false;
            this.flatButton5.Size = new System.Drawing.Size(143, 20);
            this.flatButton5.TabIndex = 29;
            this.flatButton5.Text = "Download update";
            this.flatButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton5.Visible = false;
            this.flatButton5.Click += new System.EventHandler(this.flatButton5_Click);
            // 
            // lv
            // 
            this.lv.AutoSize = true;
            this.lv.BackColor = System.Drawing.Color.Transparent;
            this.lv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lv.ForeColor = System.Drawing.Color.White;
            this.lv.Location = new System.Drawing.Point(3, 34);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(114, 14);
            this.lv.TabIndex = 29;
            this.lv.Text = "Последняя версия:";
            // 
            // cv
            // 
            this.cv.AutoSize = true;
            this.cv.BackColor = System.Drawing.Color.Transparent;
            this.cv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cv.ForeColor = System.Drawing.Color.White;
            this.cv.Location = new System.Drawing.Point(3, 18);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(99, 14);
            this.cv.TabIndex = 29;
            this.cv.Text = "Текущая версия:";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(3, 2);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(78, 14);
            this.flatLabel2.TabIndex = 29;
            this.flatLabel2.Text = "Информация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.flatButton6);
            this.panel1.Controls.Add(this.flatButton2);
            this.panel1.Controls.Add(this.flatLabel1);
            this.panel1.Controls.Add(this.flatButton1);
            this.panel1.Controls.Add(this.flatButton3);
            this.panel1.Location = new System.Drawing.Point(6, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 122);
            this.panel1.TabIndex = 27;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton2.Location = new System.Drawing.Point(6, 19);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(143, 20);
            this.flatButton2.TabIndex = 25;
            this.flatButton2.Text = "VK";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(6, 3);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(38, 14);
            this.flatLabel1.TabIndex = 28;
            this.flatLabel1.Text = "Links";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton1.Location = new System.Drawing.Point(6, 45);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(143, 20);
            this.flatButton1.TabIndex = 18;
            this.flatButton1.Text = "Telegram";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton3.Location = new System.Drawing.Point(6, 71);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(143, 20);
            this.flatButton3.TabIndex = 26;
            this.flatButton3.Text = "Lolz";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(6, 137);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(154, 35);
            this.flatButton4.TabIndex = 24;
            this.flatButton4.Text = "Настройки";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.Click += new System.EventHandler(this.flatButton4_Click);
            // 
            // flatStatusBar1
            // 
            this.flatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatStatusBar1.ForeColor = System.Drawing.Color.White;
            this.flatStatusBar1.Location = new System.Drawing.Point(0, 455);
            this.flatStatusBar1.Name = "flatStatusBar1";
            this.flatStatusBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            this.flatStatusBar1.ShowTimeDate = false;
            this.flatStatusBar1.Size = new System.Drawing.Size(680, 23);
            this.flatStatusBar1.TabIndex = 17;
            this.flatStatusBar1.Text = "HEADSHOT LLC";
            this.flatStatusBar1.TextColor = System.Drawing.Color.White;
            // 
            // xuiButton4
            // 
            this.xuiButton4.BackColor = System.Drawing.Color.Transparent;
            this.xuiButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            this.xuiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.xuiButton4.Location = new System.Drawing.Point(6, 96);
            this.xuiButton4.Name = "xuiButton4";
            this.xuiButton4.Rounded = false;
            this.xuiButton4.Size = new System.Drawing.Size(154, 35);
            this.xuiButton4.TabIndex = 16;
            this.xuiButton4.Text = "Оптимизация";
            this.xuiButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.xuiButton4.Click += new System.EventHandler(this.xuiButton4_Click_1);
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackColor = System.Drawing.Color.Transparent;
            this.xuiButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            this.xuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.xuiButton1.Location = new System.Drawing.Point(6, 55);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Rounded = false;
            this.xuiButton1.Size = new System.Drawing.Size(154, 35);
            this.xuiButton1.TabIndex = 16;
            this.xuiButton1.Text = "Чистка";
            this.xuiButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click_1);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(626, 17);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 14;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(650, 17);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 13;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panelDesktop.Location = new System.Drawing.Point(165, 55);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(506, 394);
            this.panelDesktop.TabIndex = 1;
            // 
            // flatButton6
            // 
            this.flatButton6.BackColor = System.Drawing.Color.Transparent;
            this.flatButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.flatButton6.Location = new System.Drawing.Point(6, 97);
            this.flatButton6.Name = "flatButton6";
            this.flatButton6.Rounded = false;
            this.flatButton6.Size = new System.Drawing.Size(143, 20);
            this.flatButton6.TabIndex = 29;
            this.flatButton6.Text = "GitHub";
            this.flatButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton6.Click += new System.EventHandler(this.flatButton6_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 478);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bcware Cleaner";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formSkin1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panelDesktop;
        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatButton xuiButton1;
        private FlatUI.FlatButton xuiButton4;
        public FlatUI.FlatStatusBar flatStatusBar1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatButton flatButton4;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatButton flatButton3;
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel panel2;
        private FlatUI.FlatButton flatButton5;
        private FlatUI.FlatLabel lv;
        private FlatUI.FlatLabel cv;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatButton flatButton6;
    }
}

