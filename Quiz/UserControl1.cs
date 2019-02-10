using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Random rand = new Random();
            bunifuGradientPanel1.GradientBottomLeft = Color.FromKnownColor((KnownColor)rand.Next(1, 173));
            bunifuGradientPanel1.GradientBottomRight = Color.FromKnownColor((KnownColor)rand.Next(1, 173));
            bunifuGradientPanel1.GradientTopLeft = Color.FromKnownColor((KnownColor)rand.Next(1, 173));
            bunifuGradientPanel1.GradientTopRight = Color.FromKnownColor((KnownColor)rand.Next(1, 173));
        }
        public EventHandler<EventArgs> buttonClick { get; set; }
        public string name
        {
            get => fileNameLbl.Text; set => fileNameLbl.Text = value;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (buttonClick != null)
            {
                this.buttonClick(this, e);
            }
        }
    }
}
