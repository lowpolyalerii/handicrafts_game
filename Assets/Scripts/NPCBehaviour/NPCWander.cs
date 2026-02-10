using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWander : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float leftPatrolX, rightPatrolX;

    [SerializeField] private int facingDirection = -1;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rightPatrolX || transform.position.x < leftPatrolX)
            Flip();

        rb.velocity = Vector2.right * facingDirection * speed;
    }

    void Flip()
    {
        transform.Rotate(0, 180, 0);
        facingDirection *= -1;
    }
}
