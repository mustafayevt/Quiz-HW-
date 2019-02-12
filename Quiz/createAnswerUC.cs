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
        public createAnswerUC(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public createAnswerUC(string right, string answer, int id)
        {
            InitializeComponent();
            this.right = right=="Yes"?true:false;
            this.answer = answer;
            this.id = id;
        }

        public EventHandler<EventArgs> delete { get; set; }
        public EventHandler<EventArgs> changed { get; set; }

        public bool right { get => RightAnswer.Checked; set => RightAnswer.Checked = value; }
        public string  answer { get=>answerTxtbx.Text; set=>answerTxtbx.Text=value; }
        public int id { get=>int.Parse(idLbl.Text)-1; set=>idLbl.Text = (value+1).ToString(); }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            delete(sender, e);
        }

        private void RightAnswer_OnChange(object sender, EventArgs e)
        {
            changed(sender, e);
        }
    }
}
