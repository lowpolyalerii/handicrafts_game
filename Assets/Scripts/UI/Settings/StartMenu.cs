using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameObject toggle;

    [SerializeField] private GameObject toggle2;

    [SerializeField] private AudioSource BGM;

    [SerializeField] private GameObject panels;

    [SerializeField] private GameObject drawingsettings;

    [SerializeField] private GameObject prompttext;

    [SerializeField] private GameObject SavedText;

    [SerializeField] private GameObject newPrompt;

    public void Back()
    {
        toggle.gameObject.SetActive(false);
    }

    public void SaveScreenie()
    {
        SavedText.gameObject.SetActive(true);
        prompttext.gameObject.SetActive(false);
    }

    public void NotDonePainting()
    {
        toggle2.gameObject.SetActive(false);
        BGM.volume = 1;
        panels.gameObject.SetActive(true);
        drawingsettings.gameObject.SetActive(true);
        prompttext.gameObject.SetActive(true);
        SavedText.gameObject.SetActive(false);
        newPrompt.gameObject.SetActive(true);
    }

    public void DonePainting()
    {
        toggle2.gameObject.SetActive(true);
        BGM.volume = 0;
        panels.gameObject.SetActive(false);
        drawingsettings.gameObject.SetActive(false);
        newPrompt.gameObject.SetActive(false);
    }

    public void LinktoWebsite()
    {
        Application.OpenURL("https://karimahsparacosm.online/");
    }

    public void LinktoFeedback()
    {
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSeo_pqSlYFZF_ftmWyllxSt_tSBLybxjxUXZC4GZGNF8WiYuA/viewform?usp=dialog");
    }

    public void DisclaimerToggle()
    {
        toggle.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Beginning");
    }


    public void LinkToMainWorld()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainWorld");
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
