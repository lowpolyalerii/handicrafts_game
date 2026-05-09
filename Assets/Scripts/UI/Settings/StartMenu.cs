using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject toggle;

    public void Continue()
    {
        toggle.gameObject.SetActive(false);
    }

    public void LinktoWebsite()
    {
        Application.OpenURL("https://karimahsparacosm.online/");
    }

    public void LinktoFeedback()
    {
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSeo_pqSlYFZF_ftmWyllxSt_tSBLybxjxUXZC4GZGNF8WiYuA/viewform?usp=dialog");
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Beginning");
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
