using System;
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

    [SerializeField] private GameObject FinalImageCanvas;

    [SerializeField] private GameObject DoneCanvas;

    [SerializeField] private AudioSource CameraShutter;



    IEnumerator Wait()
    {
        FinalImageCanvas.gameObject.SetActive(false);
        DoneCanvas.gameObject.SetActive(false);
        SavedText.gameObject.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        FinalImageCanvas.gameObject.SetActive(true);
        DoneCanvas.gameObject.SetActive(true);
        SavedText.gameObject.SetActive(true);
    }

    public void Back()
    {
        toggle.gameObject.SetActive(false);
    }

    public void SaveScreenie()
    {
        CameraShutter.Play();
        StartCoroutine(Wait());
        prompttext.gameObject.SetActive(false);
        string folderPath = System.Environment.ExpandEnvironmentVariables("%userprofile%\\downloads\\"); // the path of your project folder

        if (!System.IO.Directory.Exists(folderPath)) // if this path does not exist yet
            System.IO.Directory.CreateDirectory(folderPath);  // it will get created

        var screenshotName =
                                "Screenshot_" +
                                System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + // puts the current time right into the screenshot name
                                ".png"; // put youre favorite data format here
        ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(folderPath, screenshotName), 2); // takes the sceenshot, the "2" is for the scaled resolution, you can put this to 600 but it will take really long to scale the image up
        Debug.Log(folderPath + screenshotName); // You get instant feedback in the console
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
