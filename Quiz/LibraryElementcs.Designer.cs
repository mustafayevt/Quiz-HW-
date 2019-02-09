namespace Quiz
{
    partial class LibraryElementcs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryElementcs));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MediumAquamarine;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Ivory;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(124, 384);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.Black;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.Yellow;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // LibraryElementcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "LibraryElementcs";
            this.Size = new System.Drawing.Size(124, 384);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
    }
}
