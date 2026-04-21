using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public ImageToggle toggle;

    //public GameObject Audio;

    /*
    public void MusicOnAndOff()
    {
        Audio = GameObject.Find("Music");
        Audio.gameObject.SetActive(false);

        if (Audio == false)
        {
            Audio.gameObject.SetActive(true);
        }
    }
    */

    public void ExitButton()
    {
        toggle.ResumeGame();
    }

    public void Instructions()
    {

    }

    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }

    public void ExitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else

    Application.Quit();
    #endif
        //Application.Quit();
    }
}
