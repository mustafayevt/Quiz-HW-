﻿using System;
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
    public partial class createQuestionForm : Form
    {
        public createQuestionForm()
        {
            InitializeComponent();
            MainPanel.Controls.Add(new addQuestionUC());
        }
    }
}
