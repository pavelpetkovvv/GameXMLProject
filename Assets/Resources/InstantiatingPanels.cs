using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiatingPanels : MonoBehaviour
{
    public string path = "Texts.xml";
    public GameObject canvas;
    public GameObject panelPrefab;
    public GameObject EndPanel;
    public int time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(inst());
    }

    IEnumerator inst()
    {
        TextsContainer tc = TextsContainer.Load(path);

        foreach (Text_scr text in tc.texts)
        {
            GameObject newPanel = Instantiate(panelPrefab);
            newPanel.transform.SetParent(canvas.transform, false);

            ChangeText ct;
            ct = newPanel.GetComponent<ChangeText>();
            ct.changePhraseText(text.textPhrase);
            ct.changeMeaningText(text.TextMeaning);

            RemainingTime rt = newPanel.GetComponent<RemainingTime>();
            StartCoroutine(rt.changeTime(time));

            yield return new WaitForSeconds(time+1);
        }
        EndPanel.SetActive(true);
    }
}
