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
    public partial class addQuestionUC : UserControl
    {
        public addQuestionUC()
        {
            InitializeComponent();
            answersPanel.Controls.Add(new createAnswerUC());
            answersPanel.Controls.Add(new createAnswerUC());
        }

        private void addAnswerPctrbx_Click(object sender, EventArgs e)
        {
            answersPanel.Controls.Add(new createAnswerUC());
        }
    }
}
