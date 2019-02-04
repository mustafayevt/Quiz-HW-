using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Quiz
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            LoadXML();
            LoadQuestions();
        }
        List<QuestionBlock> questionsBlock;
        Result result = new Result();
        int currentQuestion = 0;
        private void LoadQuestions()
        {
            QuestionPanel.Controls.Clear();
            pageLbl.Text = $"{questionsBlock.Count - result.notAnswered} of {questionsBlock.Count}";
            int X = QuestionPanel.Location.X;
            int Y = QuestionPanel.Location.Y;
            int answerCount = questionsBlock[currentQuestion].Answers.Count;
            RadioButton[] answers = new RadioButton[answerCount];
            for (int i = 0; i < answerCount; i++)
            {
                Y += 40;
                answers[i] = new RadioButton();

                answers[i].Text = $"{questionsBlock[currentQuestion].Answers[i].Text}";

                answers[i].Location = new Point(X, Y);

                //answers[i].MaximumSize = new Size(questionRctxtbx.Width, 30);
                answers[i].AutoSize = true;

                answers[i].Tag = questionsBlock[currentQuestion].Answers[i];

                answers[i].Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Italic);
                questionRctxtbx.Text = questionsBlock[currentQuestion].Text.TrimStart();
                QuestionPanel.Controls.Add(answers[i]);
            }
            //questionPanel.Controls.AddRange(answers);
        }

        private void LoadXML()
        {
            //QuestionsXML.xml
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionBlock>));
            if (File.Exists("QuestionsXML.xml"))
            {
                using (FileStream fileStream = new FileStream("QuestionsXML.xml", FileMode.Open))
                {
                    questionsBlock = (List<QuestionBlock>)serializer.Deserialize(fileStream);
                    result.notAnswered = questionsBlock.Count;
                    result.QuestionsAndAnswers = new Dictionary<int, int>();
                }
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (currentQuestion == questionsBlock.Count-1) return;
            if (currentQuestion == questionsBlock.Count - 2 && result.QuestionsAndAnswers.ContainsKey(questionsBlock[currentQuestion+1].id)) return;
            currentQuestion++;
            if (result.QuestionsAndAnswers.ContainsKey(questionsBlock[currentQuestion].id))
                nextPage.PerformClick();
            LoadQuestions();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            if (currentQuestion == 0) return;
            if (currentQuestion == 1 && result.QuestionsAndAnswers.ContainsKey(questionsBlock[currentQuestion-1].id)) return;
            currentQuestion--;
            if (result.QuestionsAndAnswers.ContainsKey(questionsBlock[currentQuestion].id))
                previousPage.PerformClick();
            LoadQuestions();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in QuestionPanel.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                {
                    result.QuestionsAndAnswers[questionsBlock[currentQuestion].id] = (item.Tag as Answer).id;
                    result.notAnswered--;
                    if ((item.Tag as Answer).IsCorrect == "Yes") result.correct++;
                    else result.incorrect++;
                    CircleProgressBar.Value += 100 / questionsBlock.Count;
                    if (currentQuestion == questionsBlock.Count - 1) previousPage.PerformClick();
                    else nextPage.PerformClick();
                }
            }
        }
    }
}