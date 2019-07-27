using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;

    private Vector2 moveVelocity;
    private Rigidbody2D rb;
    private float yPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        yPosition = rb.position.y;
    }
    
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Vertical") != 0)
        {
            StartCoroutine(Jump());
        }
        moveVelocity = new Vector2(xMovement, 0f) * speed;
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    IEnumerator Jump() {
        rb.AddForce(new Vector2(0f, 100f));
        yield return new WaitForSecondsRealtime(0.1f);
        rb.AddForce(new Vector2(0f, -100f));
    }
}
