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

    public bool isPaused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            {
                Paused();
            }
        }
    }

    public void Paused()
    {
        if (image.activeInHierarchy == true)
        {
            image.SetActive(false);
            EdgePan.enabled = true;
            TooltipCanvases.gameObject.SetActive(true);
            Instructions.gameObject.SetActive(true);
            OBJ.gameObject.SetActive(true);
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
            interactbutton.gameObject.SetActive(false);

            Time.timeScale = 0f;
            Audio.source.volume = 0f;

            /*
            // disables hoverUI but idk how to enable
            string tag = "HoverUI"; // your tag
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
            foreach (GameObject tagged in taggedObjects)
            {
                tagged.SetActive(false); // or true
            }
            */
        }
    }

    public void Resume()
    {
        image.SetActive(false);
        EdgePan.enabled = true;
        TooltipCanvases.gameObject.SetActive(true);
        Instructions.gameObject.SetActive(true);
        OBJ.gameObject.SetActive(true);
        interactbutton.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        Audio.source.volume = 0.307f;
    }
}
