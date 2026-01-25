using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [Range(0,10f)]public float moveSpeed = 5f; //  플레이어 이동 속도

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector3(hori, verti, 0) * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 아이템을 없어지도록
        // 1. 진짜로 없애기
        // 2. 없어진처럼
        if (collision.gameObject.name == "Cha")
        {
            Debug.Log("플레이어 충돌");
            Destroy(collision.gameObject);
        }

       // collision.gameObject.SetActive(false);
    }
}
