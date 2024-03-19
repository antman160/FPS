using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //call when "play" button clicked.
    public void OnPlayButton ()
    {
        SceneManager.LoadScene(1);
    }

    //call when "Quit" button clicked.
    public void OnQuitButton ()
    {
        Application.Quit();
    }

}
