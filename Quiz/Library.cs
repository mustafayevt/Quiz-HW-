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

        private void addXmls()
        {
            List<string> xmls = LoadFiles();
            foreach (var item in xmls)
            {
                UserControl1 uc = new UserControl1();
                uc.Tag = item;
                uc.name = Path.GetFileName(item);
                uc.buttonClick += Uc_Click;
                LibraryMainPanel.Controls.Add(uc);
            }
            Button b = new Button();
            b.Click += Uc_Click;
            LibraryMainPanel.Controls.Add(b);
        }

        private void Uc_Click(object sender, EventArgs e)
        {
            filePath = (sender as UserControl1).Tag.ToString();
            this.Dispose();
        }
    }
}
