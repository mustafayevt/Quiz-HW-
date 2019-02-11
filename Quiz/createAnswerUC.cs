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
    public partial class createAnswerUC : UserControl
    {
        public createAnswerUC()
        {
            InitializeComponent();
            delete += pictureBox1_Click;
        }
        public EventHandler<EventArgs> delete { get; set; }
        public bool value { get => metroRadioButton1.Checked; set => metroRadioButton1.Checked = value; } 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
