namespace Quiz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DarkMode = new Bunifu.Framework.UI.BunifuSwitch();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.questionRctxtbx = new System.Windows.Forms.RichTextBox();
            this.MainPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.submitBtn = new MetroFramework.Controls.MetroButton();
            this.acceptBtn = new MetroFramework.Controls.MetroButton();
            this.CircleProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.previousPage = new MetroFramework.Controls.MetroButton();
            this.QuestionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nextPage = new MetroFramework.Controls.MetroButton();
            this.pageLbl = new System.Windows.Forms.Label();
            this.notAnsweredLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CorrectLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.inCorrectLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.SystemColors.HotTrack;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.DimGray;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.dragPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dragPanel
            // 
            this.dragPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dragPanel.BackgroundImage")));
            this.dragPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dragPanel.Controls.Add(this.DarkMode);
            this.dragPanel.Controls.Add(this.pictureBox1);
            this.dragPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.dragPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(34)))), ((int)(((byte)(114)))));
            this.dragPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dragPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dragPanel.Location = new System.Drawing.Point(-3, -15);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Quality = 10;
            this.dragPanel.Size = new System.Drawing.Size(1203, 52);
            this.dragPanel.TabIndex = 7;
            // 
            // DarkMode
            // 
            this.DarkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DarkMode.BorderRadius = 0;
            this.DarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DarkMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DarkMode.Location = new System.Drawing.Point(8, 27);
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Oncolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.DarkMode.Onoffcolor = System.Drawing.Color.Aqua;
            this.DarkMode.Size = new System.Drawing.Size(51, 19);
            this.DarkMode.TabIndex = 8;
            this.DarkMode.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DarkMode.Value = true;
            this.DarkMode.Click += new System.EventHandler(this.bunifuSwitch1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz.Properties.Resources.Cancel_50px;
            this.pictureBox1.Location = new System.Drawing.Point(1153, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.questionRctxtbx;
            // 
            // questionRctxtbx
            // 
            this.questionRctxtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.questionRctxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionRctxtbx.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionRctxtbx.ForeColor = System.Drawing.Color.LightCoral;
            this.questionRctxtbx.Location = new System.Drawing.Point(17, 68);
            this.questionRctxtbx.Name = "questionRctxtbx";
            this.questionRctxtbx.ReadOnly = true;
            this.questionRctxtbx.Size = new System.Drawing.Size(1158, 86);
            this.questionRctxtbx.TabIndex = 0;
            this.questionRctxtbx.Text = "";
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.questionRctxtbx);
            this.MainPanel.Controls.Add(this.submitBtn);
            this.MainPanel.Controls.Add(this.acceptBtn);
            this.MainPanel.Controls.Add(this.CircleProgressBar);
            this.MainPanel.Controls.Add(this.previousPage);
            this.MainPanel.Controls.Add(this.QuestionPanel);
            this.MainPanel.Controls.Add(this.nextPage);
            this.MainPanel.Controls.Add(this.pageLbl);
            this.MainPanel.Controls.Add(this.notAnsweredLbl);
            this.MainPanel.Controls.Add(this.CorrectLbl);
            this.MainPanel.Controls.Add(this.inCorrectLbl);
            this.MainPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.MainPanel.GradientBottomRight = System.Drawing.Color.Empty;
            this.MainPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.MainPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.MainPanel.Location = new System.Drawing.Point(0, 1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Quality = 10;
            this.MainPanel.Size = new System.Drawing.Size(1198, 550);
            this.MainPanel.TabIndex = 7;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.BackgroundImage = global::Quiz.Properties.Resources.Submit_for_Approval_50px;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitBtn.Location = new System.Drawing.Point(1046, 488);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(129, 46);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submitBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.submitBtn.UseSelectable = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.Transparent;
            this.acceptBtn.BackgroundImage = global::Quiz.Properties.Resources.Tick_Box_50px;
            this.acceptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acceptBtn.Location = new System.Drawing.Point(911, 488);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(129, 46);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Text = "ACCEPT";
            this.acceptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acceptBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.acceptBtn.UseSelectable = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // CircleProgressBar
            // 
            this.CircleProgressBar.animated = false;
            this.CircleProgressBar.animationIterval = 5;
            this.CircleProgressBar.animationSpeed = 300;
            this.CircleProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleProgressBar.BackgroundImage")));
            this.CircleProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleProgressBar.ForeColor = System.Drawing.Color.White;
            this.CircleProgressBar.LabelVisible = true;
            this.CircleProgressBar.LineProgressThickness = 3;
            this.CircleProgressBar.LineThickness = 2;
            this.CircleProgressBar.Location = new System.Drawing.Point(17, 467);
            this.CircleProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CircleProgressBar.MaxValue = 100;
            this.CircleProgressBar.Name = "CircleProgressBar";
            this.CircleProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CircleProgressBar.ProgressColor = System.Drawing.Color.LightSkyBlue;
            this.CircleProgressBar.Size = new System.Drawing.Size(67, 67);
            this.CircleProgressBar.TabIndex = 5;
            this.CircleProgressBar.Value = 0;
            this.CircleProgressBar.ProgressChanged += new System.EventHandler(this.CircleProgressBar_ProgressChanged);
            // 
            // previousPage
            // 
            this.previousPage.AutoSize = true;
            this.previousPage.BackColor = System.Drawing.Color.Transparent;
            this.previousPage.BackgroundImage = global::Quiz.Properties.Resources.Double_Left_50px;
            this.previousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousPage.Location = new System.Drawing.Point(911, 436);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(129, 46);
            this.previousPage.TabIndex = 1;
            this.previousPage.UseCustomBackColor = true;
            this.previousPage.UseCustomForeColor = true;
            this.previousPage.UseSelectable = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.AutoScroll = true;
            this.QuestionPanel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionPanel.Location = new System.Drawing.Point(17, 160);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(1158, 232);
            this.QuestionPanel.TabIndex = 0;
            // 
            // nextPage
            // 
            this.nextPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextPage.AutoSize = true;
            this.nextPage.BackColor = System.Drawing.Color.Transparent;
            this.nextPage.BackgroundImage = global::Quiz.Properties.Resources.Double_Right_50px;
            this.nextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextPage.Location = new System.Drawing.Point(1046, 436);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(129, 46);
            this.nextPage.TabIndex = 1;
            this.nextPage.UseCustomBackColor = true;
            this.nextPage.UseCustomForeColor = true;
            this.nextPage.UseSelectable = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // pageLbl
            // 
            this.pageLbl.AutoSize = true;
            this.pageLbl.BackColor = System.Drawing.Color.Transparent;
            this.pageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pageLbl.Location = new System.Drawing.Point(91, 514);
            this.pageLbl.Name = "pageLbl";
            this.pageLbl.Size = new System.Drawing.Size(35, 13);
            this.pageLbl.TabIndex = 2;
            this.pageLbl.Text = "label1";
            // 
            // notAnsweredLbl
            // 
            this.notAnsweredLbl.AutoSize = true;
            this.notAnsweredLbl.BackColor = System.Drawing.Color.Transparent;
            this.notAnsweredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAnsweredLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.notAnsweredLbl.Location = new System.Drawing.Point(861, 40);
            this.notAnsweredLbl.Name = "notAnsweredLbl";
            this.notAnsweredLbl.Size = new System.Drawing.Size(227, 25);
            this.notAnsweredLbl.TabIndex = 6;
            this.notAnsweredLbl.Text = "bunifuCustomLabel1";
            this.notAnsweredLbl.Visible = false;
            // 
            // CorrectLbl
            // 
            this.CorrectLbl.AutoSize = true;
            this.CorrectLbl.BackColor = System.Drawing.Color.Transparent;
            this.CorrectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectLbl.ForeColor = System.Drawing.Color.Green;
            this.CorrectLbl.Location = new System.Drawing.Point(78, 39);
            this.CorrectLbl.Name = "CorrectLbl";
            this.CorrectLbl.Size = new System.Drawing.Size(227, 25);
            this.CorrectLbl.TabIndex = 6;
            this.CorrectLbl.Text = "bunifuCustomLabel1";
            this.CorrectLbl.Visible = false;
            // 
            // inCorrectLbl
            // 
            this.inCorrectLbl.AutoSize = true;
            this.inCorrectLbl.BackColor = System.Drawing.Color.Transparent;
            this.inCorrectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inCorrectLbl.ForeColor = System.Drawing.Color.Crimson;
            this.inCorrectLbl.Location = new System.Drawing.Point(471, 39);
            this.inCorrectLbl.Name = "inCorrectLbl";
            this.inCorrectLbl.Size = new System.Drawing.Size(227, 25);
            this.inCorrectLbl.TabIndex = 6;
            this.inCorrectLbl.Text = "bunifuCustomLabel1";
            this.inCorrectLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1197, 546);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton nextPage;
        private System.Windows.Forms.Label pageLbl;
        private MetroFramework.Controls.MetroButton previousPage;
        private MetroFramework.Controls.MetroButton acceptBtn;
        private MetroFramework.Controls.MetroButton submitBtn;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleProgressBar;
        private Bunifu.Framework.UI.BunifuCustomLabel CorrectLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel inCorrectLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel notAnsweredLbl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private Bunifu.Framework.UI.BunifuGradientPanel MainPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel dragPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.RichTextBox questionRctxtbx;
        private System.Windows.Forms.FlowLayoutPanel QuestionPanel;
        private Bunifu.Framework.UI.BunifuSwitch DarkMode;
    }
}

