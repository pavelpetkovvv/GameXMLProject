using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControler : MonoBehaviour
{
    public void exitgame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
    public void LoadLearnScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadQuizScene()
    {
        SceneManager.LoadScene("QuizScene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
