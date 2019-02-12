namespace Quiz
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LibraryPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.addQuestionBtn = new MetroFramework.Controls.MetroButton();
            this.LibraryMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LibraryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 50;
            this.bunifuElipse4.TargetControl = this.LibraryPanel;
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LibraryPanel.BackgroundImage")));
            this.LibraryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LibraryPanel.Controls.Add(this.addQuestionBtn);
            this.LibraryPanel.Controls.Add(this.LibraryMainPanel);
            this.LibraryPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.LibraryPanel.GradientBottomRight = System.Drawing.Color.Empty;
            this.LibraryPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.LibraryPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.LibraryPanel.Location = new System.Drawing.Point(-7, 29);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Quality = 10;
            this.LibraryPanel.Size = new System.Drawing.Size(985, 473);
            this.LibraryPanel.TabIndex = 8;
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.BackColor = System.Drawing.Color.Transparent;
            this.addQuestionBtn.BackgroundImage = global::Quiz.Properties.Resources.icons8_Add_Property_50px;
            this.addQuestionBtn.Location = new System.Drawing.Point(918, 415);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(50, 50);
            this.addQuestionBtn.TabIndex = 1;
            this.addQuestionBtn.UseCustomBackColor = true;
            this.addQuestionBtn.UseCustomForeColor = true;
            this.addQuestionBtn.UseSelectable = true;
            this.addQuestionBtn.Click += new System.EventHandler(this.addQuestionBtn_Click);
            // 
            // LibraryMainPanel
            // 
            this.LibraryMainPanel.AutoScroll = true;
            this.LibraryMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.LibraryMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LibraryMainPanel.Location = new System.Drawing.Point(19, 35);
            this.LibraryMainPanel.Name = "LibraryMainPanel";
            this.LibraryMainPanel.Size = new System.Drawing.Size(949, 374);
            this.LibraryMainPanel.TabIndex = 0;
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
            this.dragPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.dragPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(34)))), ((int)(((byte)(114)))));
            this.dragPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dragPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dragPanel.Location = new System.Drawing.Point(-1, -15);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Quality = 10;
            this.dragPanel.Size = new System.Drawing.Size(976, 52);
            this.dragPanel.TabIndex = 9;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 497);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.LibraryPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.LibraryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuGradientPanel LibraryPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel dragPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.FlowLayoutPanel LibraryMainPanel;
        private MetroFramework.Controls.MetroButton addQuestionBtn;
    }
}