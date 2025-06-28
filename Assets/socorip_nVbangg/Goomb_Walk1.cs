using UnityEngine;

public class Goomb_NVBang : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }

    void FixedUpdate()
    {
        // Duy trì tốc độ di chuyển mỗi frame
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Khi va chạm tường hoặc nền → đảo chiều
        if (col.collider.CompareTag("Ground_NVBang") || col.collider.CompareTag("Obstacle"))
        {
            speed = -speed;
            Flip();
        }
    }

    void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
