using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;

[XmlRoot("QuestionCards")]
public class QuestionsContainer
{
    [XmlArray("Questions")]
    [XmlArrayItem("Question")]
    public List<Question> questions = new List<Question>();

    public static QuestionsContainer Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(QuestionsContainer));

        StringReader reader = new StringReader(_xml.text);

        QuestionsContainer questions= serializer.Deserialize(reader) as QuestionsContainer;

        reader.Close();

        return questions;
    }

}
