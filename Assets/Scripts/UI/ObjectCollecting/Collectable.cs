using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Collectable : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    public TooltipTrigger trigger;
   // public TooltipTrigger2 trigger2;

    public ObjectCollector collector;

    private void Update()
    {
        if (!collector.ScissorsFound)
            Debug.Log("AAAjkjdsjkdsjbhj");
        {
            if (trigger.display == true && trigger.mouseIn == true && trigger.mouseOut == false)
            {
                collector.ScissorsFound = true;
                FindAnyObjectByType<ObjectCollector>().AddCount();
                audioSource.Play();
            }
        }
    }
}
