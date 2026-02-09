using UnityEngine;


public class Bullet : MonoBehaviour
{
    public GM scriptGM;
    public Rigidbody2D rb;
    public float speed = 6f;
    public float time_current;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scriptGM = GameObject.Find("Gm").GetComponent<GM>(); // prefab에서 비어있는 스크립트 채우는 방법.
        rb.linearVelocity = new Vector2(0, 1) * speed;
    }

    void Update()
    {
        time_current += Time.deltaTime; // 프레임의 역수 
        if (time_current > 3)
        {
            Destroy(this.gameObject);
        } 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 태그로하는 이유: 코드작성이 쉬움
        if (collision.CompareTag("enemy"))
        {
            scriptGM.score++; // 점수 증가

            // 운석 파괴
            collision.GetComponent<ObstacleController>().isCrushed = true;
            collision.GetComponent<BoxCollider2D>().enabled = false;

        }
    }
}
