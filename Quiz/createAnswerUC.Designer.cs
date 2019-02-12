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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.RightAnswer = new Bunifu.Framework.UI.BunifuCheckbox();
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
            this.answerTxtbx.Location = new System.Drawing.Point(23, 0);
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
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(1, 3);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(16, 16);
            this.idLbl.TabIndex = 3;
            this.idLbl.Text = "1";
            // 
            // RightAnswer
            // 
            this.RightAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.RightAnswer.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.RightAnswer.Checked = false;
            this.RightAnswer.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.RightAnswer.ForeColor = System.Drawing.Color.White;
            this.RightAnswer.Location = new System.Drawing.Point(528, 1);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(20, 20);
            this.RightAnswer.TabIndex = 4;
            this.RightAnswer.OnChange += new System.EventHandler(this.RightAnswer_OnChange);
            // 
            // createAnswerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answerTxtbx);
            this.Name = "createAnswerUC";
            this.Size = new System.Drawing.Size(821, 23);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox answerTxtbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label idLbl;
        private Bunifu.Framework.UI.BunifuCheckbox RightAnswer;
    }
}
