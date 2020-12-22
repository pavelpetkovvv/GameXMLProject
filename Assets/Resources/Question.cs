using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Question
{
    [XmlElement("QuestionText")]
    public string question;

    [XmlElement("CorrectAnswer")]
    public string correctAnswer;

    [XmlArray("IncorrectAnswers")]
    [XmlArrayItem("IncorrectAnswer")]
    public string[] incorrectAnswers = new string[3];
}

