using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour
{
    UIHover UIhover;

    private void OnMouseEnter(){
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray) { 
                Debug.Log("Interacted with!"); //remove later
                UIhover = GameObject.FindGameObjectWithTag("HoverUI").GetComponent<UIHover>(); //test
                UIhover.Show();
            }
        }
    if (Input.GetKeyUp(KeyCode.E))
        {
            //dialogue code
        }
    }

    /*public NPCDialogue GetInteractableObject()
    {

    }
    */
}


