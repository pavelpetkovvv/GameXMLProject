using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LearnController : MonoBehaviour
{
    public void reloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
