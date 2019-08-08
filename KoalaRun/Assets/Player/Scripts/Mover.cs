using UnityEngine.Tilemaps;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float jumpPower;
    public Collider2D playerCollider;
    public TilemapCollider2D groundCollider;

    private Vector2 moveVelocity;
    private Rigidbody2D rb;
    private float speed = 5f;

    void Start()
    {
        speed = 5;
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && playerCollider.IsTouching(groundCollider))
        {
            rb.velocity = new Vector2(xMovement * speed, jumpPower);
        }
        speed = Input.GetKeyDown(KeyCode.LeftShift) ? 8f : 5f;
        rb.velocity = new Vector2(xMovement * speed, rb.velocity.y);
    }

}
