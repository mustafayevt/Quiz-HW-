﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quiz
{

    [Serializable]
    public class QuestionBlock
    {
        [XmlAttribute]
        public int id { get; set; }
        [XmlElement]
        public string Text { get; set; }
        [XmlArray]
        public List<Answer> Answers { get; set; }
    }    

    [Serializable]
    public class Answer
    {
        [XmlAttribute]
        public string IsCorrect { get; set; }
        [XmlAttribute]
        public int id { get; set; }
        [XmlElement]
        public string Text { get; set; }
    }
    
    public class Result
    {
        public int notAnswered { get; set; }
        public int correct { get; set; }
        public int incorrect { get; set; }
    }
}