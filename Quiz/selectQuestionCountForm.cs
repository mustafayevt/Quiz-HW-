using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class selectQuestionCountForm : Form
    {
        public selectQuestionCountForm(SelectQuestionCount select)
        {
            InitializeComponent();
            this.Controls.Add(select);
        }

        private void selectQuestionCountForm_ControlRemoved(object sender, ControlEventArgs e)
        {
            Dispose();
        }
    }
}
