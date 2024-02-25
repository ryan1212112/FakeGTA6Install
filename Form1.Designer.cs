namespace FakeInstaller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            closeButton = new PictureBox();
            icon = new PictureBox();
            label1 = new Label();
            P1panelGame = new Panel();
            P1labelF = new Label();
            P1labelV = new Label();
            label4 = new Label();
            gameCover = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            P1comboBoxV = new ComboBox();
            P1Waringlabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            F2button1 = new Button();
            P2buttonC = new Button();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            P2panel = new Panel();
            P2labelS = new Label();
            P2labelV = new Label();
            label8 = new Label();
            P2pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            P1buttonNext = new Button();
            backgroundWorkerDownLoad = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            P1panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            P2panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)P2pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Cursor = Cursors.Hand;
            closeButton.Image = (Image)resources.GetObject("closeButton.Image");
            closeButton.Location = new Point(624, 18);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(21, 18);
            closeButton.SizeMode = PictureBoxSizeMode.Zoom;
            closeButton.TabIndex = 0;
            closeButton.TabStop = false;
            closeButton.Click += closeButton_Click;
            // 
            // icon
            // 
            icon.Image = (Image)resources.GetObject("icon.Image");
            icon.Location = new Point(20, 16);
            icon.Name = "icon";
            icon.Size = new Size(21, 18);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.TabIndex = 1;
            icon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(42, 17);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 2;
            label1.Text = "進行安裝: Grand Theft Auto 6";
            // 
            // P1panelGame
            // 
            P1panelGame.Controls.Add(P1labelF);
            P1panelGame.Controls.Add(P1labelV);
            P1panelGame.Controls.Add(label4);
            P1panelGame.Controls.Add(gameCover);
            P1panelGame.Controls.Add(pictureBox3);
            P1panelGame.Location = new Point(7, 97);
            P1panelGame.Margin = new Padding(0);
            P1panelGame.Name = "P1panelGame";
            P1panelGame.Size = new Size(588, 157);
            P1panelGame.TabIndex = 9;
            // 
            // P1labelF
            // 
            P1labelF.AutoSize = true;
            P1labelF.BackColor = SystemColors.WindowFrame;
            P1labelF.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            P1labelF.ForeColor = SystemColors.ControlLight;
            P1labelF.Location = new Point(422, 125);
            P1labelF.Name = "P1labelF";
            P1labelF.Size = new Size(160, 24);
            P1labelF.TabIndex = 11;
            P1labelF.Text = "檔案大小: 12.4GB";
            // 
            // P1labelV
            // 
            P1labelV.AutoSize = true;
            P1labelV.BackColor = SystemColors.WindowFrame;
            P1labelV.Font = new Font("微軟正黑體", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            P1labelV.ForeColor = SystemColors.ControlLight;
            P1labelV.Location = new Point(248, 43);
            P1labelV.Name = "P1labelV";
            P1labelV.Size = new Size(134, 19);
            P1labelV.TabIndex = 10;
            P1labelV.Text = "版本: v0.2-winX64";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.Font = new Font("微軟正黑體", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(248, 17);
            label4.Name = "label4";
            label4.Size = new Size(266, 26);
            label4.TabIndex = 9;
            label4.Text = "Grand Theft Auto 6(Beta)";
            // 
            // gameCover
            // 
            gameCover.BorderStyle = BorderStyle.FixedSingle;
            gameCover.Image = Properties.Resources._3_6;
            gameCover.Location = new Point(12, 10);
            gameCover.Name = "gameCover";
            gameCover.Size = new Size(226, 145);
            gameCover.SizeMode = PictureBoxSizeMode.StretchImage;
            gameCover.TabIndex = 8;
            gameCover.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.WindowFrame;
            pictureBox3.Location = new Point(232, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(356, 145);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(19, 34);
            label2.Name = "label2";
            label2.Size = new Size(143, 27);
            label2.TabIndex = 0;
            label2.Text = "選擇安裝版本:";
            // 
            // P1comboBoxV
            // 
            P1comboBoxV.BackColor = Color.Black;
            P1comboBoxV.DropDownStyle = ComboBoxStyle.DropDownList;
            P1comboBoxV.FlatStyle = FlatStyle.Popup;
            P1comboBoxV.ForeColor = Color.White;
            P1comboBoxV.FormattingEnabled = true;
            P1comboBoxV.Items.AddRange(new object[] { "Grand Theft Auto 6 v0.0.1(beta) 10.2GB", "Grand Theft Auto 6 v0.0.2(beta) 12.4GB" });
            P1comboBoxV.Location = new Point(168, 36);
            P1comboBoxV.Name = "P1comboBoxV";
            P1comboBoxV.Size = new Size(427, 23);
            P1comboBoxV.TabIndex = 1;
            P1comboBoxV.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // P1Waringlabel
            // 
            P1Waringlabel.AutoSize = true;
            P1Waringlabel.ForeColor = SystemColors.Info;
            P1Waringlabel.Location = new Point(7, 331);
            P1Waringlabel.Name = "P1Waringlabel";
            P1Waringlabel.Size = new Size(348, 15);
            P1Waringlabel.TabIndex = 2;
            P1Waringlabel.Text = "*此版本為測試版本，內容可能不穩定，且不代表最終成品效果。";
            P1Waringlabel.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(P1buttonNext);
            panel1.Controls.Add(P1Waringlabel);
            panel1.Controls.Add(P1comboBoxV);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(P1panelGame);
            panel1.Location = new Point(20, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 355);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(F2button1);
            panel2.Controls.Add(P2buttonC);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(P2panel);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 355);
            panel2.TabIndex = 10;
            panel2.Visible = false;
            // 
            // F2button1
            // 
            F2button1.BackColor = Color.Black;
            F2button1.Cursor = Cursors.Hand;
            F2button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            F2button1.FlatAppearance.MouseDownBackColor = Color.Lime;
            F2button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            F2button1.FlatStyle = FlatStyle.Flat;
            F2button1.ForeColor = Color.FromArgb(0, 192, 0);
            F2button1.Location = new Point(422, 322);
            F2button1.Name = "F2button1";
            F2button1.Size = new Size(95, 23);
            F2button1.TabIndex = 14;
            F2button1.Text = "進行安裝(&I)";
            F2button1.UseVisualStyleBackColor = false;
            F2button1.Visible = false;
            F2button1.Click += F2button1_Click;
            // 
            // P2buttonC
            // 
            P2buttonC.BackColor = Color.Black;
            P2buttonC.Cursor = Cursors.Hand;
            P2buttonC.FlatAppearance.BorderColor = Color.Red;
            P2buttonC.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            P2buttonC.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            P2buttonC.FlatStyle = FlatStyle.Flat;
            P2buttonC.ForeColor = Color.Red;
            P2buttonC.Location = new Point(523, 322);
            P2buttonC.Name = "P2buttonC";
            P2buttonC.Size = new Size(95, 23);
            P2buttonC.TabIndex = 13;
            P2buttonC.Text = "取消下載(&X)";
            P2buttonC.UseVisualStyleBackColor = false;
            P2buttonC.Click += P2buttonC_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 184);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 11;
            label3.Text = "下載進度(預計時間:2小時內)";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(22, 205);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(576, 23);
            progressBar1.TabIndex = 10;
            // 
            // P2panel
            // 
            P2panel.Controls.Add(P2labelS);
            P2panel.Controls.Add(P2labelV);
            P2panel.Controls.Add(label8);
            P2panel.Controls.Add(P2pictureBox1);
            P2panel.Controls.Add(pictureBox2);
            P2panel.Location = new Point(19, 14);
            P2panel.Margin = new Padding(0);
            P2panel.Name = "P2panel";
            P2panel.Size = new Size(589, 157);
            P2panel.TabIndex = 9;
            // 
            // P2labelS
            // 
            P2labelS.AutoSize = true;
            P2labelS.BackColor = SystemColors.WindowFrame;
            P2labelS.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            P2labelS.ForeColor = SystemColors.ControlLight;
            P2labelS.Location = new Point(422, 125);
            P2labelS.Name = "P2labelS";
            P2labelS.Size = new Size(160, 24);
            P2labelS.TabIndex = 11;
            P2labelS.Text = "檔案大小: 12.4GB";
            // 
            // P2labelV
            // 
            P2labelV.AutoSize = true;
            P2labelV.BackColor = SystemColors.WindowFrame;
            P2labelV.Font = new Font("微軟正黑體", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            P2labelV.ForeColor = SystemColors.ControlLight;
            P2labelV.Location = new Point(248, 43);
            P2labelV.Name = "P2labelV";
            P2labelV.Size = new Size(134, 19);
            P2labelV.TabIndex = 10;
            P2labelV.Text = "版本: v0.2-winX64";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.WindowFrame;
            label8.Font = new Font("微軟正黑體", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(248, 17);
            label8.Name = "label8";
            label8.Size = new Size(266, 26);
            label8.TabIndex = 9;
            label8.Text = "Grand Theft Auto 6(Beta)";
            // 
            // P2pictureBox1
            // 
            P2pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            P2pictureBox1.Image = Properties.Resources._3_6;
            P2pictureBox1.Location = new Point(12, 10);
            P2pictureBox1.Name = "P2pictureBox1";
            P2pictureBox1.Size = new Size(226, 145);
            P2pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            P2pictureBox1.TabIndex = 8;
            P2pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.WindowFrame;
            pictureBox2.Location = new Point(232, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(356, 145);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // P1buttonNext
            // 
            P1buttonNext.BackColor = Color.Black;
            P1buttonNext.Cursor = Cursors.No;
            P1buttonNext.FlatAppearance.BorderColor = Color.DarkOrange;
            P1buttonNext.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            P1buttonNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            P1buttonNext.FlatStyle = FlatStyle.Flat;
            P1buttonNext.ForeColor = Color.DarkOrange;
            P1buttonNext.Location = new Point(513, 323);
            P1buttonNext.Name = "P1buttonNext";
            P1buttonNext.Size = new Size(95, 23);
            P1buttonNext.TabIndex = 8;
            P1buttonNext.Text = "開始下載(&N)";
            P1buttonNext.UseVisualStyleBackColor = false;
            P1buttonNext.EnabledChanged += button1_EnabledChanged;
            P1buttonNext.Click += P1buttonNext_Click;
            P1buttonNext.MouseLeave += button1_MouseLeave;
            P1buttonNext.MouseMove += button1_MouseMove;
            // 
            // backgroundWorkerDownLoad
            // 
            backgroundWorkerDownLoad.WorkerReportsProgress = true;
            backgroundWorkerDownLoad.WorkerSupportsCancellation = true;
            backgroundWorkerDownLoad.DoWork += backgroundWorkerDownLoad_DoWork;
            backgroundWorkerDownLoad.ProgressChanged += backgroundWorkerDownLoad_ProgressChanged;
            backgroundWorkerDownLoad.RunWorkerCompleted += backgroundWorkerDownLoad_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(667, 430);
            Controls.Add(label1);
            Controls.Add(icon);
            Controls.Add(closeButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "進行安裝: Grand Theft Auto 6";
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            P1panelGame.ResumeLayout(false);
            P1panelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gameCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            P2panel.ResumeLayout(false);
            P2panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)P2pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox closeButton;
        private PictureBox icon;
        private Label label1;
        private Panel P1panelGame;
        private Label label2;
        private ComboBox P1comboBoxV;
        private Label P1Waringlabel;
        private Panel panel1;
        private Label P1labelF;
        private Label P1labelV;
        private Label label4;
        private PictureBox gameCover;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel P2panel;
        private Label P2labelS;
        private Label P2labelV;
        private Label label8;
        private PictureBox P2pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private ProgressBar progressBar1;
        private Button P2buttonC;
        private Button P1buttonNext;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDownLoad;
        private Button F2button1;
    }
}
