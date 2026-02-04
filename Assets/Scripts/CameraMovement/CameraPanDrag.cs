using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPanDrag : MonoBehaviour
{
    private Vector3 touchStart;
    public Camera cam;
    public float groundZ = 0;

    // initialisation
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            touchStart = GetWorldPosition(groundZ);
        }
        if (Input.GetMouseButton(2))
        {
            Vector3 direction = touchStart - GetWorldPosition(groundZ);
            Camera.main.transform.position += direction;
        }
    }
    private Vector3 GetWorldPosition(float z)
    {
        Ray mousePos = cam.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(cam.transform.forward, new Vector3(0, 0, z)); ;
        float distance;
        ground.Raycast(mousePos, out distance);
        return mousePos.GetPoint(distance);
    }

}
