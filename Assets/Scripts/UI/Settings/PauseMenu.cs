using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool imageActive;
    [SerializeField] public CameraEdgePan EdgePan;
    public GameObject image;
    public GameObject TooltipCanvases;
    public GameObject Instructions;
    public RandomAudioPlay Audio;
    public GameObject OBJ;
    public GameObject interactbutton;
    GameObject[] taggedObjects = null;

    public bool isPaused;

    void OnEnable()
    {
        string tag = "HoverUI";
        taggedObjects = GameObject.FindGameObjectsWithTag(tag);
        Debug.Log(taggedObjects);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnPauseButton();
        }
    }

    public void MusicToggle()
    {
        //Audio.source.volume = 0f;
        //Audio.source.volume = 0.307f;
    }

    public void OnPauseButton()
    {
        if (!isPaused)
        {
            Paused();
        }
        else
        {
            Resume();
        }
    }

    public void Paused()
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
            Time.timeScale = 1.0f;
        }
        else
        {
            image.SetActive(true);
            EdgePan.enabled = false;
            TooltipCanvases.gameObject.SetActive(false);
            Instructions.gameObject.SetActive(false);
            OBJ.gameObject.SetActive(false);
            interactbutton.gameObject.SetActive(false);

            Time.timeScale = 0f;


            foreach (GameObject tagged in taggedObjects)
            {
                tagged.SetActive(false);
            }

        }
    }

    public void Resume()
    {
        isPaused = false;
        image.SetActive(false);
        EdgePan.enabled = true;
        TooltipCanvases.gameObject.SetActive(true);
        Instructions.gameObject.SetActive(true);
        OBJ.gameObject.SetActive(true);
        interactbutton.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        foreach (GameObject tagged in taggedObjects)
        {
            tagged.SetActive(true);
        }
    }
}
