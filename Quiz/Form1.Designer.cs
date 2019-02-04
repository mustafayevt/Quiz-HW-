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
            this.submitBtn = new MetroFramework.Controls.MetroButton();
            this.acceptBtn = new MetroFramework.Controls.MetroButton();
            this.previousPage = new MetroFramework.Controls.MetroButton();
            this.nextPage = new MetroFramework.Controls.MetroButton();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // questionRctxtbx
            // 
            this.questionRctxtbx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.questionRctxtbx.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionRctxtbx.Location = new System.Drawing.Point(23, 63);
            this.questionRctxtbx.Name = "questionRctxtbx";
            this.questionRctxtbx.ReadOnly = true;
            this.questionRctxtbx.Size = new System.Drawing.Size(1123, 96);
            this.questionRctxtbx.TabIndex = 0;
            this.questionRctxtbx.Text = "";
            // 
            // pageLbl
            // 
            this.pageLbl.AutoSize = true;
            this.pageLbl.Location = new System.Drawing.Point(70, 452);
            this.pageLbl.Name = "pageLbl";
            this.pageLbl.Size = new System.Drawing.Size(35, 13);
            this.pageLbl.TabIndex = 2;
            this.pageLbl.Text = "label1";
            // 
            // submitBtn
            // 
            this.submitBtn.BackgroundImage = global::Quiz.Properties.Resources.icons8_Enter_50px;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitBtn.Location = new System.Drawing.Point(1017, 417);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(129, 46);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submitBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.submitBtn.UseSelectable = true;
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackgroundImage = global::Quiz.Properties.Resources.icons8_Checked_Radio_Button_50px;
            this.acceptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.acceptBtn.Location = new System.Drawing.Point(882, 417);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(129, 46);
            this.acceptBtn.TabIndex = 3;
            this.acceptBtn.Text = "ACCEPT";
            this.acceptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.acceptBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.acceptBtn.UseSelectable = true;
            // 
            // previousPage
            // 
            this.previousPage.AutoSize = true;
            this.previousPage.BackgroundImage = global::Quiz.Properties.Resources._1icons8_Next_page_50px;
            this.previousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousPage.Location = new System.Drawing.Point(882, 365);
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
            this.nextPage.Location = new System.Drawing.Point(1017, 365);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(129, 46);
            this.nextPage.TabIndex = 1;
            this.nextPage.UseCustomBackColor = true;
            this.nextPage.UseCustomForeColor = true;
            this.nextPage.UseSelectable = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 3;
            this.bunifuCircleProgressbar1.LineThickness = 2;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(-4, 406);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(67, 67);
            this.bunifuCircleProgressbar1.TabIndex = 5;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1169, 467);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.pageLbl);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.questionRctxtbx);
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
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
    }
}

