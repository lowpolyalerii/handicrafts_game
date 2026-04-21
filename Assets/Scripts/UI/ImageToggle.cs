using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageToggle : MonoBehaviour
{
    public bool imageActive;
    [SerializeField] public CameraEdgePan EdgePan;
    public GameObject image;
    public GameObject TooltipCanvases;
    public GameObject Settingsicon;
    public GameObject Instructions;
    public RandomAudioPlay Audio;
    public GameObject OBJ;
    public GameObject ExitButton;
    public GameObject interactbutton;

    public void Displaying()
    {
        if (image.activeInHierarchy == true)
        {
            image.SetActive(false);
            EdgePan.enabled = true;
            TooltipCanvases.gameObject.SetActive(true);
            Instructions.gameObject.SetActive(true);
            OBJ.gameObject.SetActive(true);
            Settingsicon.gameObject.SetActive(true);
            ExitButton.gameObject.SetActive(false);
            interactbutton.gameObject.SetActive(true);
            Time.timeScale = 1.0f;
            Audio.source.volume = 0.307f;
        }
        else
        {
            image.SetActive(true);
            EdgePan.enabled = false;
            TooltipCanvases.gameObject.SetActive(false);
            Instructions.gameObject.SetActive(false);
            OBJ.gameObject.SetActive(false);
            Settingsicon.gameObject.SetActive(false);
            interactbutton.gameObject.SetActive(false);
            ExitButton.gameObject.SetActive(true);
            Time.timeScale = 0f;
            Audio.source.volume = 0f;
        }
    }

    public void ResumeGame()
    {
        image.SetActive(false);
        EdgePan.enabled = true;
        TooltipCanvases.gameObject.SetActive(true);
        Instructions.gameObject.SetActive(true);
        OBJ.gameObject.SetActive(true);
        Settingsicon.gameObject.SetActive(true);
        ExitButton.gameObject.SetActive(false);
        interactbutton.gameObject.SetActive(true);
        Time.timeScale = 1.0f;
        Audio.source.volume = 0.307f;
    }
}
