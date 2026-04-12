using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger2 : MonoBehaviour
{

    public bool display;
    public bool mouseIn;
    public bool mouseOut;

    //[SerializeField] AudioSource audioSource;

    public string header;
    [Multiline()] public string content;

    public void Start()
    {
        display = false;
        mouseIn = false;
        mouseOut = true;
    }

    public void Displaying()
    {
        if (display == true && mouseIn == true && mouseOut == false)
        {
            TooltipSystem2.Show(content, header);
            
        }

        if (display == false && mouseIn == true && mouseOut == false)
        {
            TooltipSystem2.Hide();

        }

        if (display == false && mouseIn == false && mouseOut == true)
        {
            TooltipSystem2.Hide();
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
                    //audioSource.Play();
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