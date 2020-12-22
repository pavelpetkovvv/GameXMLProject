using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("Cards")]
public class TextsContainer
{
    [XmlArray("Texts")]
    [XmlArrayItem("Text")]
    public List<Text_scr> texts = new List<Text_scr>();


    public static TextsContainer Load(string path)//method for initializing "texts" list by reading from xml file
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);

        XmlSerializer serializer = new XmlSerializer(typeof(TextsContainer));

        StringReader reader = new StringReader(_xml.text);

        TextsContainer texts = serializer.Deserialize(reader) as TextsContainer;

        reader.Close();

        return texts;
    }
}
