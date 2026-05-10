using UnityEngine;

public class CameraEdgePan : MonoBehaviour
{

    [SerializeField] float panSpeed;
    [SerializeField] float edgeSizeInPixels;  // How many pixels away from the edge of the screen the mouse can be before panning begins
    [SerializeField] private bool useEdgeScrolling = false; //Added edge scrolling as option

    private Vector2 lastMousePosition;

    bool MouseIsAtLeftEdge => Input.mousePosition.x <= edgeSizeInPixels;
    bool MouseIsAtRightEdge => Mathf.Abs(Input.mousePosition.x - Screen.width) <= edgeSizeInPixels;
    bool MouseIsAtBottomEdge => Input.mousePosition.y <= edgeSizeInPixels;
    bool MouseIsAtTopEdge => Mathf.Abs(Input.mousePosition.y - Screen.height) <= edgeSizeInPixels;

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            lastMousePosition = Input.mouseScrollDelta;
        }
 

        if (useEdgeScrolling)
        {
            if (MouseIsAtLeftEdge)
                PanCameraInDirection(Vector2.left);

            if (MouseIsAtRightEdge)
                PanCameraInDirection(Vector2.right);

            if (MouseIsAtTopEdge)
                PanCameraInDirection(Vector2.up);

            if (MouseIsAtBottomEdge)
                PanCameraInDirection(Vector2.down);
        }

    }

    void PanCameraInDirection(Vector2 direction) => transform.Translate(direction * panSpeed * Time.deltaTime);

}