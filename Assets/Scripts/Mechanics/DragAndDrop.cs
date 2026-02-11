using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 mousePosition;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
    }
    private void OnMouseDrag()
    {
        rb.MovePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition)); //making obj clip
    }
}