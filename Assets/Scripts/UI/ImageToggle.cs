using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ImageToggle : MonoBehaviour
{
    public bool imageActive;
    [SerializeField] public CameraEdgePan EdgePan;
    public GameObject image;
    public GameObject TooltipCanvases;
    public GameObject Instructions;
    public RandomAudioPlay Audio;
    public GameObject OBJ;
    public GameObject interactbutton;
    public GameObject Settingsicon;

    public WorldDialogue2 Foundall;
    public GameObject DispelToggle;

    GameObject[] taggedObjects = null;

    public bool isPaused;

    void OnEnable()
    {
        string tag = "HoverUI";
        taggedObjects = GameObject.FindGameObjectsWithTag(tag);
        Debug.Log(taggedObjects);
    }

    public void OnPauseButton()
    {
        if (!isPaused)
        {
            DisplayingImage();
        }
        else
        {
            ResumeGame();
        }
    }

    public void DisplayingImage()
    {
        isPaused = true;
        if (image.activeInHierarchy == true)
        {
            image.SetActive(false);
            EdgePan.enabled = true;
            TooltipCanvases.gameObject.SetActive(true);
            Instructions.gameObject.SetActive(true);
            OBJ.gameObject.SetActive(true);
            interactbutton.gameObject.SetActive(false);
            DispelToggle.gameObject.SetActive(false);
            Settingsicon.gameObject.SetActive(true);
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
            DispelToggle.gameObject.SetActive(false);

            Time.timeScale = 0f;
            Audio.source.volume = 0f;

            /*
            foreach (GameObject tagged in taggedObjects)
            {
                tagged.SetActive(false);
            }
            */
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        image.SetActive(false);
        EdgePan.enabled = true;
        TooltipCanvases.gameObject.SetActive(true);
        Instructions.gameObject.SetActive(true);
        OBJ.gameObject.SetActive(true);
        interactbutton.gameObject.SetActive(false);
        Settingsicon.gameObject.SetActive(true);
        DispelToggle.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        Audio.source.volume = 0.307f;

        /* makes all object interacts true after close
        foreach (GameObject tagged in taggedObjects)
        {
            tagged.SetActive(true);
        }
        */
    }
}
