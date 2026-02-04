using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    Rigidbody rb;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);

        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;

        rb.isKinematic = true;

    }

    private void OnMouseUp()
    {
        rb.isKinematic = false;
    }


}