using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Collectable : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    public TooltipTrigger trigger;

    public ObjectCollector collector;

    private void Update()
    {
        if (!collector.isCounting)
        {
            if (trigger.display == true && trigger.mouseIn == true && trigger.mouseOut == false)
            {
                collector.isCounting = false;
                FindAnyObjectByType<ObjectCollector>().AddCount();
                audioSource.Play();
            }
        }
    }
}
