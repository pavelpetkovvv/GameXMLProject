using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{

    public Text pharseText;
    public Text meaningText;
    public void changePhraseText(string newText)
    {
        pharseText.text = newText;
    }

    public void changeMeaningText(string newText)
    {
        meaningText.text = newText;
    }
}
