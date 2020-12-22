using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainingTime : MonoBehaviour
{
    public Text timeDisplay;
    public IEnumerator changeTime()
    {
        for(int i = 10; i >= 0; i--)
        {
            timeDisplay.text = i.ToString();
            yield return new WaitForSeconds(1);

        }
    }
}
