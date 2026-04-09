using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger5 : MonoBehaviour
{

    public bool display;
    public bool mouseIn;
    public bool mouseOut;
    public bool showing = false;

    //[SerializeField] AudioSource audioSource;

    public string header;
    [Multiline()] public string content;

    public void Start()
    {
        display = false;

    }

    public void Displaying()
    {
        if (display == true && mouseIn == true && mouseOut == false)
        {
            TooltipSystem5.Show(content, header);
            showing = true;
        }

        if (display == false && mouseIn == true && mouseOut == false)
        {
            TooltipSystem5.Hide();
            showing = false;
        }

        if (display == false && mouseIn == false && mouseOut == true)
        {
            TooltipSystem5.Hide();
            showing = false;
        }
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!display)
            {
                if (mouseOut == false)
                {
                    display = true;
                    //audioSource.GetComponent<AudioSource>().Play();
                }
            }

            else if (display == true)
            {
                display = false;
            }
        }

        Displaying();
    }

    public void OnMouseEnter()
    {
        mouseIn = true;
        mouseOut = false;
    }


    public void OnMouseExit()
    {
        mouseIn = false;
        mouseOut = true;
    }

}