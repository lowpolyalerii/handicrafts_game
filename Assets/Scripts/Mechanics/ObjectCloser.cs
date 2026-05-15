using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCloser : MonoBehaviour
{

    [SerializeField] bool trigger = false;
    [SerializeField] private float rotateSpeed = 60;
    Vector3 currentEulerAngles;


    private void MoveOnZ(float amount)
        {
            transform.position += transform.forward * amount;
        }

    public void OnMouseEnter()
    {
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                trigger = true;
            }
        }
    }

    public void OnMouseExit()
    {
        trigger = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Z) & trigger == true)
        {
            MoveOnZ(-2);
        }

        if (Input.GetKey(KeyCode.X ) & trigger == true)
        {
            MoveOnZ(2);
        }

        if (Input.GetKey(KeyCode.A) & trigger == true)
        {
            currentEulerAngles += new Vector3(0, 0, -2) * Time.deltaTime * rotateSpeed;

            transform.localEulerAngles = currentEulerAngles;
        }

        if (Input.GetKey(KeyCode.D) & trigger == true)
        {
            currentEulerAngles += new Vector3(0, 0, 2) * Time.deltaTime * rotateSpeed;

            transform.localEulerAngles = currentEulerAngles;
        }

        if (Input.GetKey(KeyCode.W) & trigger == true)
        {
            currentEulerAngles += new Vector3(-2, 0, 0) * Time.deltaTime * rotateSpeed;

            transform.localEulerAngles = currentEulerAngles;
        }

        if (Input.GetKey(KeyCode.S) & trigger == true)
        {
            currentEulerAngles += new Vector3(2, 0, 0) * Time.deltaTime * rotateSpeed;

            transform.localEulerAngles = currentEulerAngles;
        }
    }
}
