using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwanTrigger : MonoBehaviour
{
    public bool trigger = false;


    void OnMouseDrag()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            trigger = true;
        }
    }

    private void OnMouseExit()
    {
        trigger = false;
    }
}
