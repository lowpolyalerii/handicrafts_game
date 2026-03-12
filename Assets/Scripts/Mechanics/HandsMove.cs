using UnityEngine;

public class HandsMove : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    Rigidbody rb;
    Vector3 position = new Vector3(0f, 0f, 0f); 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = 28f;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
        position = Vector3.Lerp(transform.position, pos, moveSpeed);
        rb.MovePosition(position);
    }

    /*
    Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Rigidbody rb;
    Vector2 position = new Vector2(-15.39f, 7.877244f);

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
    /// </summary>
    /// 

    */
}