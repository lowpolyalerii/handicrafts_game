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
        isPaused = true;
        Time.timeScale = 0f;

        image.SetActive(!gameObject.activeInHierarchy);
        TooltipCanvases.SetActive(!gameObject.activeInHierarchy);
        Instructions.SetActive(!gameObject.activeInHierarchy);
        OBJ.gameObject.SetActive(!gameObject.activeInHierarchy);

        if (EdgePan.enabled == true)
        {
            EdgePan.enabled = false;
            Audio.source.volume = 0;
        }
        else
        {
            EdgePan.enabled = true;
            isPaused = false;
            Audio.source.volume = 0.307f;
            Time.timeScale = 1.0f;
        }
    }
}
