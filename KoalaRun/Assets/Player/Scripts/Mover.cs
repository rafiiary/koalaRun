using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    public float jumpPower;

    private Vector2 moveVelocity;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(xMovement * speed, jumpPower);
        }
        rb.velocity = new Vector2(xMovement * speed, rb.velocity.y);
    }

}
