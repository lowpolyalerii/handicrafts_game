using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour
{
    //DollDialogue dollDialogue;
    public bool trigger;

    public void Start()
    {
        trigger = false;
    }

    public void OnMouseEnter() {
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray) {
                Debug.Log("Interacted with!"); //remove later
                trigger = true;
            }
        }
    }

    public void OnMouseExit()
    {
        trigger = false;
    }
}


