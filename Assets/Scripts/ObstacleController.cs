using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public Animator animator;
    public GM scriptGm;
    //데이터타입 이름 값
    public Rigidbody2D rb;
    [Range(0, 10)] public float moveSpeed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = new Vector2(0, -1) * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetTrigger("crushed");

        // = : 대입 , == : 비교 (같은지 다른지)
        if (collision.name == "player")
        {
            Debug.Log("플레이어 파괴");
            // [선호 1순위]1. 파괴된 것처럼 보이도록 // 선호 이유는 연결되어있는 스크립트들이 destroy될 시 간섭이 있을수 있어서
            //collision.gameObject.SetActive(false); // 인스펙터창에서 오브젝트 체크박스 해제
            // true : 체크, false : 체크해제

            // 2. 실제로 파괴
            Destroy(collision.gameObject);

        }

        if (collision.name == "deadzone")
        {
            Debug.Log("목숨 - 1");

            scriptGm.playerLife--;//-= 1;
            scriptGm.UpdateHeartUI();
        }
    }
}
