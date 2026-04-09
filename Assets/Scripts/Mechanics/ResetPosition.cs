using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 originalPos;
    Quaternion initialRotation;

    private void Start()
    {
        originalPos = gameObject.transform.position;
        initialRotation = gameObject.transform.rotation;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            transform.position = originalPos;
            transform.rotation = initialRotation;
        }
    }
}
