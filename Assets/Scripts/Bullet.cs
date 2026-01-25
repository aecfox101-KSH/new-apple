using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GM scriptGM;
    public Rigidbody2D rb;
    public float speed = 6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = new Vector2(0, 1) * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 태그로하는 이유: 코드작성이 쉬움
        if (collision.CompareTag("enemy"))
        {
            scriptGM.score++; // 점수 증가

             Destroy(collision.gameObject);// 운석 파괴
            // collision.gameObject.SetActive(false);

        }
    }
}
