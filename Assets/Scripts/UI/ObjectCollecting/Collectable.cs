using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Collectable : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    public TooltipTrigger trigger;
    public TooltipTrigger2 trigger2;
    public TooltipTrigger3 trigger3;
    public TooltipTrigger4 trigger4;
    public TooltipTrigger5 trigger5;

    public ObjectCollector collector;

    private void Update()
    {
        if (!collector.ScissorsFound)

        {
            if (trigger.display == true && trigger.mouseIn == true && trigger.mouseOut == false)
            {

                collector.ScissorsFound = true;
                FindAnyObjectByType<ObjectCollector>().AddCount();
                audioSource.Play();
            }
        }

        if (!collector.PaperFound)

        {
            if (trigger2.display == true && trigger2.mouseIn == true && trigger2.mouseOut == false)
            {

                collector.PaperFound = true;
                FindAnyObjectByType<ObjectCollector>().AddCount();
                audioSource.Play();
            }
        }


        if (!collector.PenFound)

        {
            if (trigger3.display == true && trigger3.mouseIn == true && trigger3.mouseOut == false)
            {

                collector.PenFound = true;
                FindAnyObjectByType<ObjectCollector>().AddCount();
                audioSource.Play();
            }
        }

        if (!collector.HairtieFound)

        {
            if (trigger4.display == true && trigger4.mouseIn == true && trigger4.mouseOut == false)
            {

                collector.HairtieFound = true;
                FindAnyObjectByType<ObjectCollector>().AddCount();
                audioSource.Play();
            }
        }


        if (!collector.PlushieFound)

        {
            if (trigger5.display == true && trigger5.mouseIn == true && trigger5.mouseOut == false)
            {

                collector.PlushieFound = true;
                FindAnyObjectByType<ObjectCollector>().AddCount();
                audioSource.Play();
            }


        }
    }
}
