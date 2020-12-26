using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainingTime : MonoBehaviour
{
    public Text timeDisplay;
    public int time = 15;
    public IEnumerator changeTime(int seconds)
    {
        for(int i = seconds; i >= 0; i--)
        {
            timeDisplay.text = i.ToString();
            yield return new WaitForSeconds(1);

        }
    }
}
