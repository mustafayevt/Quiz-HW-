namespace Quiz
{
    partial class createAnswerUC
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
            this.answerTxtbx = new MetroFramework.Controls.MetroTextBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // answerTxtbx
            // 
            this.answerTxtbx.BackColor = System.Drawing.SystemColors.ActiveBorder;
            // 
            // 
            // 
            this.answerTxtbx.CustomButton.Image = null;
            this.answerTxtbx.CustomButton.Location = new System.Drawing.Point(477, 1);
            this.answerTxtbx.CustomButton.Name = "";
            this.answerTxtbx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.answerTxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.answerTxtbx.CustomButton.TabIndex = 1;
            this.answerTxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.answerTxtbx.CustomButton.UseSelectable = true;
            this.answerTxtbx.CustomButton.Visible = false;
            this.answerTxtbx.Lines = new string[0];
            this.answerTxtbx.Location = new System.Drawing.Point(0, 0);
            this.answerTxtbx.MaxLength = 32767;
            this.answerTxtbx.Name = "answerTxtbx";
            this.answerTxtbx.PasswordChar = '\0';
            this.answerTxtbx.PromptText = "Answer:";
            this.answerTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.answerTxtbx.SelectedText = "";
            this.answerTxtbx.SelectionLength = 0;
            this.answerTxtbx.SelectionStart = 0;
            this.answerTxtbx.ShortcutsEnabled = true;
            this.answerTxtbx.Size = new System.Drawing.Size(499, 23);
            this.answerTxtbx.TabIndex = 0;
            this.answerTxtbx.Theme = MetroFramework.MetroThemeStyle.Light;
            this.answerTxtbx.UseCustomBackColor = true;
            this.answerTxtbx.UseCustomForeColor = true;
            this.answerTxtbx.UseSelectable = true;
            this.answerTxtbx.UseStyleColors = true;
            this.answerTxtbx.WaterMark = "Answer:";
            this.answerTxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.answerTxtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.metroRadioButton1.Location = new System.Drawing.Point(505, -2);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(133, 25);
            this.metroRadioButton1.TabIndex = 1;
            this.metroRadioButton1.Text = "Right Answer";
            this.metroRadioButton1.UseCustomBackColor = true;
            this.metroRadioButton1.UseCustomForeColor = true;
            this.metroRadioButton1.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz.Properties.Resources.icons8_Trash_50px_1;
            this.pictureBox1.Location = new System.Drawing.Point(781, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // createAnswerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.answerTxtbx);
            this.Name = "createAnswerUC";
            this.Size = new System.Drawing.Size(821, 23);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox answerTxtbx;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
