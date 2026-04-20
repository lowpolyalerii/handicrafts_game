using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageToggle : MonoBehaviour
{
    public bool imageActive;
    [SerializeField] public CameraEdgePan cameraEdgePan;
    public GameObject image;
    public GameObject TooltipCanvases;
    public GameObject Instructions;
    public RandomAudioPlay Audio;
    public GameObject OBJ;


    void Start()
    {
        imageActive = false;
        image.gameObject.SetActive(false);
    }

    public void PauseMenu()
    {
        imageActive = !imageActive;
        image.gameObject.SetActive(true);

        TooltipCanvases.gameObject.SetActive(false);
        Instructions.gameObject.SetActive(false);
        OBJ.gameObject.SetActive(false);
        cameraEdgePan.enabled = false;
        Audio.source.volume = 0;

        if (!imageActive)
        {
            image.SetActive(false);
            TooltipCanvases.gameObject.SetActive(true);
            Instructions.gameObject.SetActive(true);
            cameraEdgePan.enabled = true;
            OBJ.gameObject.SetActive(true);
            Audio.source.volume = 0.307f;
        }


    }
}
