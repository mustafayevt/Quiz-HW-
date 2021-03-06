﻿namespace Quiz
{
    partial class addQuestionUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addQuestionUC));
            this.LibraryPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.addAnswerPctrbx = new System.Windows.Forms.PictureBox();
            this.answersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.questionTxtbx = new MetroFramework.Controls.MetroTextBox();
            this.LibraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addAnswerPctrbx)).BeginInit();
            this.SuspendLayout();
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LibraryPanel.BackgroundImage")));
            this.LibraryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LibraryPanel.Controls.Add(this.pictureBox1);
            this.LibraryPanel.Controls.Add(this.idLbl);
            this.LibraryPanel.Controls.Add(this.addAnswerPctrbx);
            this.LibraryPanel.Controls.Add(this.answersPanel);
            this.LibraryPanel.Controls.Add(this.questionTxtbx);
            this.LibraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraryPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.LibraryPanel.GradientBottomRight = System.Drawing.Color.Empty;
            this.LibraryPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.LibraryPanel.GradientTopRight = System.Drawing.Color.SteelBlue;
            this.LibraryPanel.Location = new System.Drawing.Point(0, 0);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Quality = 10;
            this.LibraryPanel.Size = new System.Drawing.Size(927, 250);
            this.LibraryPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Quiz.Properties.Resources.icons8_Trash_50px_1;
            this.pictureBox1.Location = new System.Drawing.Point(894, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.BackColor = System.Drawing.Color.Transparent;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.Color.White;
            this.idLbl.Location = new System.Drawing.Point(3, 4);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(16, 18);
            this.idLbl.TabIndex = 2;
            this.idLbl.Text = "1";
            // 
            // addAnswerPctrbx
            // 
            this.addAnswerPctrbx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addAnswerPctrbx.BackColor = System.Drawing.Color.Transparent;
            this.addAnswerPctrbx.Image = global::Quiz.Properties.Resources.icons8_Plus_50px;
            this.addAnswerPctrbx.Location = new System.Drawing.Point(894, 78);
            this.addAnswerPctrbx.Name = "addAnswerPctrbx";
            this.addAnswerPctrbx.Size = new System.Drawing.Size(30, 30);
            this.addAnswerPctrbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addAnswerPctrbx.TabIndex = 0;
            this.addAnswerPctrbx.TabStop = false;
            this.addAnswerPctrbx.Click += new System.EventHandler(this.addAnswerPctrbx_Click);
            // 
            // answersPanel
            // 
            this.answersPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answersPanel.AutoScroll = true;
            this.answersPanel.BackColor = System.Drawing.Color.Transparent;
            this.answersPanel.Location = new System.Drawing.Point(35, 78);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(853, 169);
            this.answersPanel.TabIndex = 1;
            // 
            // questionTxtbx
            // 
            this.questionTxtbx.BackColor = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.questionTxtbx.CustomButton.Image = null;
            this.questionTxtbx.CustomButton.Location = new System.Drawing.Point(785, 1);
            this.questionTxtbx.CustomButton.Name = "";
            this.questionTxtbx.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.questionTxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.questionTxtbx.CustomButton.TabIndex = 1;
            this.questionTxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.questionTxtbx.CustomButton.UseSelectable = true;
            this.questionTxtbx.CustomButton.Visible = false;
            this.questionTxtbx.Lines = new string[0];
            this.questionTxtbx.Location = new System.Drawing.Point(35, 3);
            this.questionTxtbx.MaxLength = 32767;
            this.questionTxtbx.Multiline = true;
            this.questionTxtbx.Name = "questionTxtbx";
            this.questionTxtbx.PasswordChar = '\0';
            this.questionTxtbx.PromptText = "Question:";
            this.questionTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.questionTxtbx.SelectedText = "";
            this.questionTxtbx.SelectionLength = 0;
            this.questionTxtbx.SelectionStart = 0;
            this.questionTxtbx.ShortcutsEnabled = true;
            this.questionTxtbx.Size = new System.Drawing.Size(853, 69);
            this.questionTxtbx.TabIndex = 0;
            this.questionTxtbx.UseCustomBackColor = true;
            this.questionTxtbx.UseCustomForeColor = true;
            this.questionTxtbx.UseSelectable = true;
            this.questionTxtbx.UseStyleColors = true;
            this.questionTxtbx.WaterMark = "Question:";
            this.questionTxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.questionTxtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addQuestionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LibraryPanel);
            this.Name = "addQuestionUC";
            this.Size = new System.Drawing.Size(927, 250);
            this.LibraryPanel.ResumeLayout(false);
            this.LibraryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addAnswerPctrbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel LibraryPanel;
        private System.Windows.Forms.FlowLayoutPanel answersPanel;
        private MetroFramework.Controls.MetroTextBox questionTxtbx;
        private System.Windows.Forms.PictureBox addAnswerPctrbx;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
