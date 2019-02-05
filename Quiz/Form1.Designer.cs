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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.questionRctxtbx = new System.Windows.Forms.RichTextBox();
            this.pageLbl = new System.Windows.Forms.Label();
            this.QuestionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CorrectLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.inCorrectLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.notAnsweredLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CircleProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.submitBtn = new MetroFramework.Controls.MetroButton();
            this.acceptBtn = new MetroFramework.Controls.MetroButton();
            this.previousPage = new MetroFramework.Controls.MetroButton();
            this.nextPage = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // questionRctxtbx
            // 
            this.questionRctxtbx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.questionRctxtbx.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionRctxtbx.Location = new System.Drawing.Point(28, 63);
            this.questionRctxtbx.Name = "questionRctxtbx";
            this.questionRctxtbx.ReadOnly = true;
            this.questionRctxtbx.Size = new System.Drawing.Size(1158, 86);
            this.questionRctxtbx.TabIndex = 0;
            this.questionRctxtbx.Text = "";
            // 
            // pageLbl
            // 
            this.pageLbl.AutoSize = true;
            this.pageLbl.Location = new System.Drawing.Point(65, 483);
            this.pageLbl.Name = "pageLbl";
            this.pageLbl.Size = new System.Drawing.Size(35, 13);
            this.pageLbl.TabIndex = 2;
            this.pageLbl.Text = "label1";
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.AutoScroll = true;
            this.QuestionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.QuestionPanel.Location = new System.Drawing.Point(28, 155);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(1158, 232);
            this.QuestionPanel.TabIndex = 0;
            // 
            // CorrectLbl
            // 
            this.CorrectLbl.AutoSize = true;
            this.CorrectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CorrectLbl.Location = new System.Drawing.Point(148, 34);
            this.CorrectLbl.Name = "CorrectLbl";
            this.CorrectLbl.Size = new System.Drawing.Size(227, 25);
            this.CorrectLbl.TabIndex = 6;
            this.CorrectLbl.Text = "bunifuCustomLabel1";
            this.CorrectLbl.Visible = false;
            // 
            // inCorrectLbl
            // 
            this.inCorrectLbl.AutoSize = true;
            this.inCorrectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inCorrectLbl.ForeColor = System.Drawing.Color.Crimson;
            this.inCorrectLbl.Location = new System.Drawing.Point(526, 34);
            this.inCorrectLbl.Name = "inCorrectLbl";
            this.inCorrectLbl.Size = new System.Drawing.Size(227, 25);
            this.inCorrectLbl.TabIndex = 6;
            this.inCorrectLbl.Text = "bunifuCustomLabel1";
            this.inCorrectLbl.Visible = false;
            // 
            // notAnsweredLbl
            // 
            this.notAnsweredLbl.AutoSize = true;
            this.notAnsweredLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAnsweredLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.notAnsweredLbl.Location = new System.Drawing.Point(918, 34);
            this.notAnsweredLbl.Name = "notAnsweredLbl";
            this.notAnsweredLbl.Size = new System.Drawing.Size(227, 25);
            this.notAnsweredLbl.TabIndex = 6;
            this.notAnsweredLbl.Text = "bunifuCustomLabel1";
            this.notAnsweredLbl.Visible = false;
            // 
            // CircleProgressBar
            // 
            this.CircleProgressBar.animated = false;
            this.CircleProgressBar.animationIterval = 5;
            this.CircleProgressBar.animationSpeed = 300;
            this.CircleProgressBar.BackColor = System.Drawing.Color.White;
            this.CircleProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleProgressBar.BackgroundImage")));
            this.CircleProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleProgressBar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CircleProgressBar.LabelVisible = true;
            this.CircleProgressBar.LineProgressThickness = 3;
            this.CircleProgressBar.LineThickness = 2;
            this.CircleProgressBar.Location = new System.Drawing.Point(1, 437);
            this.CircleProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CircleProgressBar.MaxValue = 100;
            this.CircleProgressBar.Name = "CircleProgressBar";
            this.CircleProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CircleProgressBar.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.CircleProgressBar.Size = new System.Drawing.Size(67, 67);
            this.CircleProgressBar.TabIndex = 5;
            this.CircleProgressBar.Value = 0;
            // 
            // submitBtn
            // 
            this.submitBtn.BackgroundImage = global::Quiz.Properties.Resources.icons8_Enter_50px;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitBtn.Location = new System.Drawing.Point(1057, 448);
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
            this.acceptBtn.BackgroundImage = global::Quiz.Properties.Resources.icons8_Checked_Radio_Button_50px;
            this.acceptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acceptBtn.Location = new System.Drawing.Point(922, 450);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(129, 46);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Text = "ACCEPT";
            this.acceptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acceptBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.acceptBtn.UseSelectable = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // previousPage
            // 
            this.previousPage.AutoSize = true;
            this.previousPage.BackgroundImage = global::Quiz.Properties.Resources._1icons8_Next_page_50px;
            this.previousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousPage.Location = new System.Drawing.Point(922, 396);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(129, 46);
            this.previousPage.TabIndex = 1;
            this.previousPage.UseCustomBackColor = true;
            this.previousPage.UseCustomForeColor = true;
            this.previousPage.UseSelectable = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextPage.AutoSize = true;
            this.nextPage.BackgroundImage = global::Quiz.Properties.Resources.icons8_Next_page_50px;
            this.nextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextPage.Location = new System.Drawing.Point(1057, 396);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(129, 46);
            this.nextPage.TabIndex = 1;
            this.nextPage.UseCustomBackColor = true;
            this.nextPage.UseCustomForeColor = true;
            this.nextPage.UseSelectable = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1209, 501);
            this.Controls.Add(this.notAnsweredLbl);
            this.Controls.Add(this.inCorrectLbl);
            this.Controls.Add(this.CorrectLbl);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.questionRctxtbx);
            this.Controls.Add(this.CircleProgressBar);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.pageLbl);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.nextPage);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox questionRctxtbx;
        private MetroFramework.Controls.MetroButton nextPage;
        private System.Windows.Forms.Label pageLbl;
        private MetroFramework.Controls.MetroButton previousPage;
        private MetroFramework.Controls.MetroButton acceptBtn;
        private MetroFramework.Controls.MetroButton submitBtn;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleProgressBar;
        private System.Windows.Forms.FlowLayoutPanel QuestionPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel CorrectLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel inCorrectLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel notAnsweredLbl;
    }
}

