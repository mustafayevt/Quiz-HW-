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

            foreach (var item in this.Controls.OfType<RadioButton>())
            {
                item.Dispose();
            }
            pageLbl.Text = $"{currentQuestion + 1} of {questionsBlock.Count}";
            int X = questionRctxtbx.Location.X;
            int Y = questionRctxtbx.Location.Y;
            Y += 80;
            int answerCount = questionsBlock[currentQuestion].Answers.Count;
            RadioButton[] answers = new RadioButton[answerCount];
            for (int i = 0; i < answerCount; i++)
            {
                Y += 40;
                answers[i] = new RadioButton();
                answers[i].Text = $"{questionsBlock[currentQuestion].Answers[i].Text}";
                answers[i].Location = new Point(X, Y);
                answers[i].AutoSize = true;
                answers[i].MaximumSize = new Size(questionRctxtbx.Size.Width, 30);
                answers[i].Tag = questionsBlock[currentQuestion].Answers[i];
                answers[i].AutoSize = true;
                answers[i].Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Italic);
                questionRctxtbx.Text = questionsBlock[currentQuestion].Text.TrimStart();
            }
            this.Controls.AddRange(answers);
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
                }
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (currentQuestion == questionsBlock.Count-1) return;
            currentQuestion++;
            LoadQuestions();
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            if (currentQuestion == 0) return;
            currentQuestion--;
            LoadQuestions();
        }
    }
}