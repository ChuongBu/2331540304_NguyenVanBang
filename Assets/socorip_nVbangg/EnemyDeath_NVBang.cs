using UnityEngine;

public class EnemyDeath_NVBang : MonoBehaviour
{
    private Animator animator;
    private bool isDead = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;

        if (collision.collider.CompareTag("Player"))
        {
            isDead = true;
            animator.SetTrigger("Dead");

            // Ngãn Goomba di chuy?n thêm
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Collider2D>().enabled = false;

            // G?i s? ki?n game over sau khi Goomba ch?t 1s
            FindObjectOfType<GameManager_NVBang>().GameOver();
        }
    }
}
