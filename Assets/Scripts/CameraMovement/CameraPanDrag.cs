using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraPanDrag : MonoBehaviour
{
    private Vector3 touchStart;

    public float panSpeed = 10;       // Speed of the camera when being panned

    private Vector3 mouseOrigin;    // Position of cursor when mouse dragging starts
    private bool isPanning;     // Is the camera being panned?

    void FixedUpdate()
    {
        // Get the middle mouse button
        if (Input.GetMouseButtonDown(2))
        {
            // Get mouse origin
            mouseOrigin = Input.mousePosition;
            isPanning = true;
        }

        // Disable movements on button release
        if (!Input.GetMouseButton(2)) isPanning = false;

        // Move the camera on it's XY plane
        if (isPanning)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            Vector3 move = new Vector3(pos.x * panSpeed, pos.y * panSpeed, 0);
            transform.Translate(move, Space.Self);
        }
    }
}
