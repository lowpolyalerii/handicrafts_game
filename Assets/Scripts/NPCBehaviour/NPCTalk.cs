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
            // Debug.Log($"trigger={trigger}");
        }


        if (Input.GetKeyUp(KeyCode.E))
        {
            // (dialogue);
        }
    }

    public void OnMouseExit()
    {
        trigger = false;
        // Debug.Log($"trigger={trigger}");
    }

    /*public NPCDialogue GetInteractableObject()
    {

    }
    */
}


