using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRB;
    [Range(0,10f)] public float speed = 6f; // 범위 표시 드래그 창 만들기 range 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 수직 방향키를 눌렀을때 값을 가져올려면?
        float verti = Input.GetAxis("Vertical");


        // 수평 방향키를 눌렀을때 값을 가져옴, -1(왼쪽) ~ 1(오른쪽) 사이의 값
        float hori = Input.GetAxis("Horizontal"); 
        
        // 1. 속도 조절
        // 2. 방향키에 따라 이동
        playerRB.linearVelocity = new Vector2(hori, verti) * speed; // 앞의 변수에는 없고, 새롭게 만들었기 때문에 new 라고 붙임.


    }
}
