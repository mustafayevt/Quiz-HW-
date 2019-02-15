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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
            addXmls();
        }
        public static string filePath { get; set; }
        private List<string> LoadFiles()
        {
            List<FileInfo> files = new List<FileInfo>();
            List<string> xmls = new List<string>();
            if (!Directory.Exists("xmls"))
                System.IO.Directory.CreateDirectory("xmls");
            foreach (var item in Directory.GetFiles("xmls"))
            {
                files.Add(new FileInfo(item));
            }
            foreach (var item in files)
            {
                if (item.Extension == ".xml")
                    xmls.Add(item.FullName);
            }
            return xmls;
        }

        public void addXmls()
        {
            List<string> xmls = LoadFiles();
            foreach (var item in xmls)
            {
                xmlLibraryElementUC uc = new xmlLibraryElementUC();
                uc.Tag = item;
                uc.name = Path.GetFileName(item);
                uc.buttonClick += Uc_Click;
                LibraryMainPanel.Controls.Add(uc);
            }
        }

        private void Uc_Click(object sender, EventArgs e)
        {
            filePath = (sender as xmlLibraryElementUC).Tag.ToString();
            this.Dispose();
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            new createQuestionForm().ShowDialog();
            LibraryMainPanel.Controls.Clear();
            addXmls();
        }
    }
}
