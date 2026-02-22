using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour
{
    public bool trigger;

    public void OnMouseEnter() {
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray) {
                Debug.Log("Interacted with!"); //remove later
                trigger = true;
            }
        }


        if (Input.GetKeyUp(KeyCode.E))
        {
            // (dialogue);
            // if dialogue triggered hide e icon while talking
        }
    }

    public void OnMouseExit()
    {
        trigger = false;

    }
}


