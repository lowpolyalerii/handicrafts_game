using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectUIHover : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private ObjectUIHover Object;
    public bool trigger;

    public void Start()
    {
        Object.trigger = false;
        Hide();
    }

    public void OnMouseEnter()
    {
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                Object.trigger = true;
            }
        }

        if (Object.trigger == true)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    public void OnMouseExit()
    {
        Object.trigger = false;
        Hide();
    }

    //----------------------

    public void Show()
    {
        containerGameObject.SetActive(true);
    }

    public void Hide()
    {
        containerGameObject.SetActive(false);
    }
}
