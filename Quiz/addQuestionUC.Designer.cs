namespace Quiz
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
            this.answersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.questionTxtbx = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.LibraryPanel.SuspendLayout();
            this.answersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LibraryPanel.BackgroundImage")));
            this.LibraryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LibraryPanel.Controls.Add(this.answersPanel);
            this.LibraryPanel.Controls.Add(this.questionTxtbx);
            this.LibraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraryPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(92)))));
            this.LibraryPanel.GradientBottomRight = System.Drawing.Color.Empty;
            this.LibraryPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(56)))));
            this.LibraryPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.LibraryPanel.Location = new System.Drawing.Point(0, 0);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Quality = 10;
            this.LibraryPanel.Size = new System.Drawing.Size(949, 250);
            this.LibraryPanel.TabIndex = 9;
            // 
            // answersPanel
            // 
            this.answersPanel.BackColor = System.Drawing.Color.Transparent;
            this.answersPanel.Controls.Add(this.metroTextBox1);
            this.answersPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.answersPanel.Location = new System.Drawing.Point(3, 78);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(946, 169);
            this.answersPanel.TabIndex = 1;
            // 
            // questionTxtbx
            // 
            this.questionTxtbx.BackColor = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.questionTxtbx.CustomButton.Image = null;
            this.questionTxtbx.CustomButton.Location = new System.Drawing.Point(881, 1);
            this.questionTxtbx.CustomButton.Name = "";
            this.questionTxtbx.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.questionTxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.questionTxtbx.CustomButton.TabIndex = 1;
            this.questionTxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.questionTxtbx.CustomButton.UseSelectable = true;
            this.questionTxtbx.CustomButton.Visible = false;
            this.questionTxtbx.Lines = new string[0];
            this.questionTxtbx.Location = new System.Drawing.Point(0, 3);
            this.questionTxtbx.MaxLength = 32767;
            this.questionTxtbx.Multiline = true;
            this.questionTxtbx.Name = "questionTxtbx";
            this.questionTxtbx.PasswordChar = '\0';
            this.questionTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.questionTxtbx.SelectedText = "";
            this.questionTxtbx.SelectionLength = 0;
            this.questionTxtbx.SelectionStart = 0;
            this.questionTxtbx.ShortcutsEnabled = true;
            this.questionTxtbx.Size = new System.Drawing.Size(949, 69);
            this.questionTxtbx.TabIndex = 0;
            this.questionTxtbx.UseCustomBackColor = true;
            this.questionTxtbx.UseCustomForeColor = true;
            this.questionTxtbx.UseSelectable = true;
            this.questionTxtbx.UseStyleColors = true;
            this.questionTxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.questionTxtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(3, 3);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(473, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseCustomForeColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addQuestionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LibraryPanel);
            this.Name = "addQuestionUC";
            this.Size = new System.Drawing.Size(949, 250);
            this.LibraryPanel.ResumeLayout(false);
            this.answersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel LibraryPanel;
        private System.Windows.Forms.FlowLayoutPanel answersPanel;
        private MetroFramework.Controls.MetroTextBox questionTxtbx;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}
