using UnityEngine;

public class T0201Obstacle : MonoBehaviour
{
    public Rigidbody2D rb;

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); // this 생략 가능
        animator = this.GetComponent<Animator>();
        rb.linearVelocity = new Vector2(1, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetTrigger("aa");
    }
}
