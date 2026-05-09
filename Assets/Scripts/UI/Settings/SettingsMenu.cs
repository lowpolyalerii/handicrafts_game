using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public ImageToggle toggle;
    public BlurController blur;

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
        blur._blurVolume.weight = blur._blurActive ? 0 : 0;
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
