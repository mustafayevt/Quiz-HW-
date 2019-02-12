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
using System.Xml;
using System.Xml.Serialization;

namespace Quiz
{
    public partial class createQuestionForm : Form
    {
        public createQuestionForm()
        {
            InitializeComponent();
            MainPanel.Controls.Add(new addQuestionUC());
        }
        List<QuestionBlock> questions;

        private void addAnswerPctrbx_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(new addQuestionUC());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in MainPanel.Controls.OfType<addQuestionUC>())
            {
                item.setQuestionBlock();
                if(item.newQuestion.Text == "" || item.newQuestion.Answers.Count<2 || item.newQuestion.Answers.Exists(x => x.Text==""))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Please, fill in all fields","Error To Save");
                    return;
                }
            }
            questions = new List<QuestionBlock>();
            foreach (var item in MainPanel.Controls.OfType<addQuestionUC>())
            {
                questions.Add(item.newQuestion);
            }

            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<QuestionBlock>));

            string utf8;
            using (StringWriter writer = new Utf8StringWriter())
            {
                xsSubmit.Serialize(writer,questions);
                utf8 = writer.ToString();
            }
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML-File | *.xml";
            saveFileDialog.InitialDirectory = Path.GetFullPath("xmls");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName,utf8);
                MessageBox.Show("Saved!");
            }
            this.Dispose();
        }

        private void MainPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.Copy;
        }

        private void MainPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                if (Path.GetExtension(paths[0]) != ".xml")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Wrong Extension", "Error To Open File");
                    return;
                }
                XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionBlock>));
                List<QuestionBlock> tmp;
                using (FileStream fileStream = new FileStream(paths[0], FileMode.Open))
                {
                    tmp = (List<QuestionBlock>)serializer.Deserialize(fileStream);
                }
                MainPanel.Controls.Clear();
                addQuestionUC.staticID = 0;
                foreach (var item in tmp)
                {
                    MainPanel.Controls.Add(new addQuestionUC(item));
                }

            }
        }
    }
    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
