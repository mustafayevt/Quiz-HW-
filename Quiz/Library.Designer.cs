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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LibraryPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.libraryElementcs1 = new Quiz.LibraryElementcs();
            this.libraryElementcs2 = new Quiz.LibraryElementcs();
            this.libraryElementcs3 = new Quiz.LibraryElementcs();
            this.libraryElementcs4 = new Quiz.LibraryElementcs();
            this.LibraryPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            // LibraryPanel
            // 
            this.LibraryPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LibraryPanel.BackgroundImage")));
            this.LibraryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LibraryPanel.Controls.Add(this.flowLayoutPanel1);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.libraryElementcs1);
            this.flowLayoutPanel1.Controls.Add(this.libraryElementcs2);
            this.flowLayoutPanel1.Controls.Add(this.libraryElementcs3);
            this.flowLayoutPanel1.Controls.Add(this.libraryElementcs4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(976, 417);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // libraryElementcs1
            // 
            this.libraryElementcs1.BackColor = System.Drawing.Color.Red;
            this.libraryElementcs1.Location = new System.Drawing.Point(3, 3);
            this.libraryElementcs1.Name = "libraryElementcs1";
            this.libraryElementcs1.Size = new System.Drawing.Size(124, 384);
            this.libraryElementcs1.TabIndex = 0;
            // 
            // libraryElementcs2
            // 
            this.libraryElementcs2.BackColor = System.Drawing.Color.Red;
            this.libraryElementcs2.Location = new System.Drawing.Point(133, 3);
            this.libraryElementcs2.Name = "libraryElementcs2";
            this.libraryElementcs2.Size = new System.Drawing.Size(124, 384);
            this.libraryElementcs2.TabIndex = 0;
            // 
            // libraryElementcs3
            // 
            this.libraryElementcs3.BackColor = System.Drawing.Color.Red;
            this.libraryElementcs3.Location = new System.Drawing.Point(263, 3);
            this.libraryElementcs3.Name = "libraryElementcs3";
            this.libraryElementcs3.Size = new System.Drawing.Size(124, 384);
            this.libraryElementcs3.TabIndex = 0;
            // 
            // libraryElementcs4
            // 
            this.libraryElementcs4.BackColor = System.Drawing.Color.Red;
            this.libraryElementcs4.Location = new System.Drawing.Point(393, 3);
            this.libraryElementcs4.Name = "libraryElementcs4";
            this.libraryElementcs4.Size = new System.Drawing.Size(124, 384);
            this.libraryElementcs4.TabIndex = 0;
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
            this.Text = "Library";
            this.LibraryPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuGradientPanel LibraryPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel dragPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private LibraryElementcs libraryElementcs1;
        private LibraryElementcs libraryElementcs2;
        private LibraryElementcs libraryElementcs3;
        private LibraryElementcs libraryElementcs4;
    }
}