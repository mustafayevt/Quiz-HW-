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
    public partial class Form1 : Form
    {
        public Form1()
        {
            Library library = new Library();
            library.ShowDialog();
            InitializeComponent();
            LoadXML();
        }

        public List<QuestionBlock> questionsBlock;
        Result result = new Result();
        int currentQuestion = 0;
        bool submited = false;
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
                answers[i].MinimumSize = new Size(QuestionPanel.Width - 6, 30);
                answers[i].AutoSize = true;

                answers[i].Tag = questionsBlock[currentQuestion].Answers[i];

                answers[i].MouseEnter += MouseEnterRDBTN;
                answers[i].MouseLeave += MouseLeaveRDBTN;

                answers[i].BackColor = Color.Transparent;
                answers[i].ForeColor = DarkMode.Value ? Color.LightCoral : Color.Aqua;
                answers[i].Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Italic);
                questionRctxtbx.Text = $"{currentQuestion + 1}) {questionsBlock[currentQuestion].Text.TrimStart()}";
                QuestionPanel.Controls.Add(answers[i]);
            }
            if (result.QuestionsAndAnswers.ContainsKey(questionsBlock[currentQuestion].id) || submited)
            {
                try
                {
                    QuestionPanel.Enabled = false;
                    foreach (var item in QuestionPanel.Controls.OfType<RadioButton>())
                    {
                        if ((item.Tag as Answer).id == result.QuestionsAndAnswers[questionsBlock[currentQuestion].id])
                        {
                            item.Checked = true;
                        }
                        if (item.Checked && submited)
                        {
                            item.BackColor = Color.Red;
                        }
                        if (submited && (item.Tag as Answer).IsCorrect == "Yes")
                        {
                            item.BackColor = Color.Green;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            else QuestionPanel.Enabled = true;
        }

        private void MouseLeaveRDBTN(object sender, EventArgs e)
        {
            (sender as RadioButton).BackColor = Color.Transparent;
        }

        private void MouseEnterRDBTN(object sender, EventArgs e)
        {
            (sender as RadioButton).BackColor = Color.FromArgb(58, 46, 57);
        }

        private void LoadXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionBlock>));
            if (File.Exists(Library.filePath))
            {
                using (FileStream fileStream = new FileStream(Library.filePath, FileMode.Open))
                {
                    questionsBlock = (List<QuestionBlock>)serializer.Deserialize(fileStream);
                    questionsBlock.Shuffle();
                    questionsBlock.ForEach(x => x.Answers.Shuffle());
                    result.notAnswered = questionsBlock.Count;
                    result.QuestionsAndAnswers = new Dictionary<int, int>();
                }
            }

            //QuestionsXML.xml
            LoadQuestions();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (currentQuestion == questionsBlock.Count - 1) return;
            if (submited)
            {
                for (int i = currentQuestion + 1; i < questionsBlock.Count; i++)
                {
                    if (result.QuestionsAndAnswers.ContainsKey(questionsBlock[i].id))
                    {
                        currentQuestion = i;
                        LoadQuestions();
                        return;
                    }
                }
            }
            else
            {
                currentQuestion++;
                LoadQuestions();
            }
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            if (currentQuestion == 0) return;
            if (submited)
            {
                for (int i = currentQuestion - 1; i >= 0; i--)
                {
                    if (result.QuestionsAndAnswers.ContainsKey(questionsBlock[i].id))
                    {
                        currentQuestion = i;
                        LoadQuestions();
                        return;
                    }
                }
            }
            else
            {
                currentQuestion--;
                LoadQuestions();
            }
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
                    nextPage.PerformClick();
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            submitBtn.Visible = false;
            acceptBtn.Visible = false;
            CircleProgressBar.Visible = false;
            pageLbl.Visible = false;

            CorrectLbl.Visible = true;
            inCorrectLbl.Visible = true;
            notAnsweredLbl.Visible = true;

            CorrectLbl.Text = $"Correct Answers {result.correct.ToString()}";
            inCorrectLbl.Text = $"Incorrect Answers {result.incorrect.ToString()}";
            notAnsweredLbl.Text = $"Not Answered {result.notAnswered.ToString()}";
            submited = true;
            nextPage.Location = new Point(nextPage.Location.X, nextPage.Location.Y + nextPage.Height);
            previousPage.Location = new Point(previousPage.Location.X, previousPage.Location.Y + previousPage.Height);

            if (result.notAnswered == questionsBlock.Count)
            {
                questionRctxtbx.Text = "";
                QuestionPanel.Controls.Clear();
                return;
            }
            currentQuestion = 0;
            nextPage.PerformClick();
            LoadQuestions();
        }

        private void CircleProgressBar_ProgressChanged(object sender, EventArgs e)
        {
            if (CircleProgressBar.Value == 100) submitBtn.PerformClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (DarkMode.Value)
            {
                MainPanel.GradientBottomLeft = Color.FromArgb(30, 85, 92);
                MainPanel.GradientTopLeft = Color.FromArgb(1, 22, 56);
                MainPanel.GradientTopRight = Color.FromArgb(163, 22, 33);

                dragPanel.GradientBottomLeft = Color.FromArgb(41, 51, 92);
                dragPanel.GradientBottomRight = Color.FromArgb(244, 34, 114);

                questionRctxtbx.ForeColor = Color.LightCoral;
                foreach (var item in QuestionPanel.Controls.OfType<RadioButton>())
                {
                    (item as RadioButton).ForeColor = Color.LightCoral;
                }
            }
            else
            {
                MainPanel.GradientBottomLeft = Color.DarkCyan;
                MainPanel.GradientTopLeft = Color.DarkGray;
                MainPanel.GradientTopRight = Color.DarkOliveGreen;

                dragPanel.GradientBottomLeft = Color.DarkCyan;
                dragPanel.GradientBottomRight = Color.DarkGray;

                questionRctxtbx.ForeColor = Color.Aqua;
                foreach (var item in QuestionPanel.Controls.OfType<RadioButton>())
                {
                    (item as RadioButton).ForeColor = Color.Aqua;
                }
            }
        }
    }
}