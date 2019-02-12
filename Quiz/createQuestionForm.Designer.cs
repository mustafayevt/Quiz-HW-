namespace Quiz
{
    partial class createQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createQuestionForm));
            this.dragPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LibraryPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.addAnswerPctrbx = new System.Windows.Forms.PictureBox();
            this.LibraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addAnswerPctrbx)).BeginInit();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dragPanel.BackgroundImage")));
            this.dragPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dragPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.dragPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(34)))), ((int)(((byte)(114)))));
            this.dragPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dragPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dragPanel.Location = new System.Drawing.Point(-2, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Quality = 10;
            this.dragPanel.Size = new System.Drawing.Size(996, 41);
            this.dragPanel.TabIndex = 11;
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LibraryPanel.BackgroundImage")));
            this.LibraryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LibraryPanel.Controls.Add(this.addAnswerPctrbx);
            this.LibraryPanel.Controls.Add(this.saveBtn);
            this.LibraryPanel.Controls.Add(this.MainPanel);
            this.LibraryPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.LibraryPanel.GradientBottomRight = System.Drawing.Color.Empty;
            this.LibraryPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.LibraryPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.LibraryPanel.Location = new System.Drawing.Point(0, 30);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Quality = 10;
            this.LibraryPanel.Size = new System.Drawing.Size(994, 590);
            this.LibraryPanel.TabIndex = 10;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BackgroundImage = global::Quiz.Properties.Resources.icons8_Save_50px;
            this.saveBtn.Location = new System.Drawing.Point(918, 528);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(50, 50);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.UseCustomBackColor = true;
            this.saveBtn.UseCustomForeColor = true;
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AllowDrop = true;
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Location = new System.Drawing.Point(12, 17);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(956, 505);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainPanel_DragDrop);
            this.MainPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainPanel_DragEnter);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this;
            // 
            // addAnswerPctrbx
            // 
            this.addAnswerPctrbx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addAnswerPctrbx.BackColor = System.Drawing.Color.Transparent;
            this.addAnswerPctrbx.Image = global::Quiz.Properties.Resources.icons8_Plus_50px;
            this.addAnswerPctrbx.Location = new System.Drawing.Point(862, 528);
            this.addAnswerPctrbx.Name = "addAnswerPctrbx";
            this.addAnswerPctrbx.Size = new System.Drawing.Size(50, 50);
            this.addAnswerPctrbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addAnswerPctrbx.TabIndex = 2;
            this.addAnswerPctrbx.TabStop = false;
            this.addAnswerPctrbx.Click += new System.EventHandler(this.addAnswerPctrbx_Click);
            // 
            // createQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 620);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.LibraryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createQuestionForm";
            this.LibraryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addAnswerPctrbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel dragPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel LibraryPanel;
        private MetroFramework.Controls.MetroButton saveBtn;
        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.PictureBox addAnswerPctrbx;
    }
}