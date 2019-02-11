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
    public partial class SelectQuestionCount : UserControl
    {
        public SelectQuestionCount(int count)
        {
            InitializeComponent();
            slider.Maximum = count;
            slider.Value = count;
            countLbl.Text = $"{slider.Value} of {slider.Maximum}";
        }

        public int value { get => slider.Value; set => slider.Value = value; }

        private void slider_ValueChanged(object sender, EventArgs e)
        {
            countLbl.Text = $"{slider.Value} of {slider.Maximum}";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
