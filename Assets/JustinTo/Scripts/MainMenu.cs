using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Map");
    }

    public void QuitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
