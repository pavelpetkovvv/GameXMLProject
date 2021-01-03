using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionPanelController : MonoBehaviour
{
    public Button button1;
    public Text bt1Text;
    public Button button2;
    public Text bt2Text;
    public Button button3;
    public Text bt3Text;
    public Button button4;
    public Text bt4Text;

    public Text questionText;

    public static int pressedButton = 1;
    public static int correctButton = 1;


    public void setPressedButtonToOne()
    {
        pressedButton = 1;
    }
    public void setPressedButtonToTwo()
    {
        pressedButton = 2;
    }
    public void setPressedButtonToThree()
    {
        pressedButton = 3;
    }
    public void setPressedButtonToFour()
    {
        pressedButton = 4;
    }

    
}
