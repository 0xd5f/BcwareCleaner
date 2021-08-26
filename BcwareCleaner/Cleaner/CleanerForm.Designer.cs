
namespace ClearCore.Cleaner
{
    partial class CleanerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xuiCircleProgressBar1 = new FlatUI.FlatProgressBar();
            this.button2 = new FlatUI.FlatButton();
            this.button4 = new FlatUI.FlatButton();
            this.button3 = new FlatUI.FlatButton();
            this.button1 = new FlatUI.FlatButton();
            this.label1 = new FlatUI.FlatLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.xuiCircleProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(4, 340);
            this.xuiCircleProgressBar1.Maximum = 100;
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Pattern = true;
            this.xuiCircleProgressBar1.PercentSign = false;
            this.xuiCircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.xuiCircleProgressBar1.ShowBalloon = true;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(442, 42);
            this.xuiCircleProgressBar1.TabIndex = 20;
            this.xuiCircleProgressBar1.Text = "flatProgressBar1";
            this.xuiCircleProgressBar1.Value = 0;
            this.xuiCircleProgressBar1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.Location = new System.Drawing.Point(92, 302);
            this.button2.Name = "button2";
            this.button2.Rounded = false;
            this.button2.Size = new System.Drawing.Size(82, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Обновить";
            this.button2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button4.Location = new System.Drawing.Point(316, 302);
            this.button4.Name = "button4";
            this.button4.Rounded = false;
            this.button4.Size = new System.Drawing.Size(130, 32);
            this.button4.TabIndex = 18;
            this.button4.Text = "Импортировать";
            this.button4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button3.Location = new System.Drawing.Point(180, 302);
            this.button3.Name = "button3";
            this.button3.Rounded = false;
            this.button3.Size = new System.Drawing.Size(130, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "Экспортировать";
            this.button3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BcwareCleaner.Properties.Resources.archeology;
            this.button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.Location = new System.Drawing.Point(4, 302);
            this.button1.Name = "button1";
            this.button1.Rounded = false;
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Очистить";
            this.button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button1.Visible = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Status";
            this.label1.Visible = false;
            // 
            // CleanerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(453, 394);
            this.Controls.Add(this.xuiCircleProgressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CleanerForm";
            this.Text = "ClearCore";
            this.Load += new System.EventHandler(this.CleanerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public FlatUI.FlatLabel label1;
        public FlatUI.FlatButton button1;
        public FlatUI.FlatButton button3;
        public FlatUI.FlatButton button4;
        public FlatUI.FlatButton button2;
        public FlatUI.FlatProgressBar xuiCircleProgressBar1;
    }
}