using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class NPCWander : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float leftPatrolX, rightPatrolX;

    [SerializeField] private float minPauseTime, maxPauseTime;
    [SerializeField] private float minWalkTime, maxWalkTime;

    [SerializeField] private int facingDirection = -10;

    private float randomTime, timer;
    private bool isWalking;

    private void Start()
    {
        randomTime = Random.Range(maxWalkTime, minWalkTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= randomTime)
            StateChange();

        if (transform.position.x > rightPatrolX || transform.position.x < leftPatrolX)
            Flip();

        if (isWalking)
        rb.velocity = Vector3.right * facingDirection * speed;
    }

    void Flip()
    {
        transform.Rotate(0, 180, 0);
        facingDirection *= -10;
    }

    void StateChange()
    {
        isWalking = !isWalking;
        randomTime = isWalking ? Random.Range(minWalkTime, maxWalkTime) : Random.Range(minPauseTime, maxPauseTime);
        timer = 0;
    }
}
