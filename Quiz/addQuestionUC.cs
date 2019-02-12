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
            createAnswerUC uc1 = new createAnswerUC(answerID++);
            createAnswerUC uc2 = new createAnswerUC(answerID++);

            uc1.delete += refreshId;
            uc1.delete += deleteAnswer;
            uc2.delete += deleteAnswer;
            uc2.delete += refreshId;

            uc1.right = true;

            uc1.changed += RightAnswerSelected;
            uc2.changed += RightAnswerSelected;

            answersPanel.Controls.Add(uc1);
            answersPanel.Controls.Add(uc2);

            id = staticID++;
            setQuestionBlock();
        }
        public addQuestionUC(QuestionBlock question)
        {
            InitializeComponent();
            text = question.Text;
            this.id = question.id;
            foreach (var item in question.Answers)
            {
                createAnswerUC uc1 = new createAnswerUC(item.IsCorrect,item.Text,item.id);
                uc1.delete += refreshId;
                uc1.delete += deleteAnswer;
                uc1.changed += RightAnswerSelected;

                answersPanel.Controls.Add(uc1);

                answerID++;
            }
            staticID++;
            setQuestionBlock();
        }
        public static int staticID { get; set; } = 0;
        public int answerID { get; set; } = 0;
        public int id { get=>int.Parse(idLbl.Text)-1; set=>idLbl.Text = (value+1).ToString(); }
        public string text { get => questionTxtbx.Text; set => questionTxtbx.Text = value; }

        public QuestionBlock newQuestion = new QuestionBlock();

        private void deleteAnswer(object sender,EventArgs e)
        {
            answerID--;
        }

        public void setQuestionBlock()
        {
            newQuestion.Text = questionTxtbx.Text;
            newQuestion.Answers = new List<Answer>();
            newQuestion.id = id;
            foreach (var item in answersPanel.Controls.OfType<createAnswerUC>())
            {
                Answer a = new Answer
                {
                    id = item.id,
                    Text = item.answer,
                    IsCorrect = item.right ? "Yes" : "No"
                };
                newQuestion.Answers.Add(a);
            }
        }

        private void addAnswerPctrbx_Click(object sender, EventArgs e)
        {
            createAnswerUC uc1 = new createAnswerUC(answerID++);
            uc1.delete += refreshId;
            uc1.delete += deleteAnswer;
            uc1.changed += RightAnswerSelected;

            answersPanel.Controls.Add(uc1);
            refreshId(sender, e);
            setQuestionBlock();
        }

        private void refreshId(object sender,EventArgs e)
        {
            int i = 0;
                foreach (var item in answersPanel.Controls.OfType<createAnswerUC>())
                {
                    (item as createAnswerUC).id = i++;
                }
        }

        private void RightAnswerSelected(object sender,EventArgs e)
        {
            foreach (var item in answersPanel.Controls.OfType<createAnswerUC>())
            {
                item.right = false;
            }
            (sender as Bunifu.Framework.UI.BunifuCheckbox).Checked = true;
            setQuestionBlock();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
