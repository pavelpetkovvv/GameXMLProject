using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextsLoader : MonoBehaviour
{
    public string path = "Texts.xml";

    // Start is called before the first frame update
    void Start()
    {
        TextsContainer tc = TextsContainer.Load(path);

        foreach(Text_scr text in tc.texts)
        {
            //print("Phrase: \n");
            print(text.textPhrase);
            //print("meaning: \n");
            print(text.TextMeaning);
        }
    }

}
