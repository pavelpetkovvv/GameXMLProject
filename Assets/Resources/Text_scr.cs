using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Text_scr
{
    [XmlElement("TextPhrase")]
    public string textPhrase;

    [XmlElement("TextMeaning")]
    public string TextMeaning;
}
