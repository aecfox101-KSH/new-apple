using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRB;
    [Range(0,10f)] public float speed = 6f; // 범위 표시 드래그 창 만들기 range 

    public GameObject shoot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트를 가져와서 playerRB 변수에 저장
        playerRB.bodyType = RigidbodyType2D.Kinematic; // 물리엔진의 영향을 받지 않도록 설정
    }

    // Update is called once per frame
    void Update()
    {
        MovementLimit2();

        // 수평 방향키를 눌렀을때 값을 가져옴, -1(왼쪽) ~ 1(오른쪽) 사이의 값
        float hori = Input.GetAxis("Horizontal"); 
        
        // 1. 속도 조절
        // 2. 방향키에 따라 이동
        playerRB.linearVelocity = new Vector2(hori, 0) * speed; // 앞의 변수에는 없고, 새롭게 만들었기 때문에 new 라고 붙임.

        if(Input.GetKeyDown(KeyCode.Z))
        {
            // Instantiate - 복제(오브젝트, 어디다가, 회전 각도) 
            Instantiate(shoot, this.transform.position, Quaternion.identity); // this는 생략 가능 
        }

    }

    public void MovementLimit()
    {
        // 비행기의 위치 값을 가져옴.
        Vector3 pos = this.transform.position; // 위치값(-5,-2.7,0)을 가져온거지 "비행기의 위치" 그자체를 가져온 것이 아님.

        // 위치 " 값 "을 보정
        if (pos.x < - 2.8f)
        {
            pos.x = -2.8f; // (-2.8,-2.7,0)
        }
        if (pos.x > 2.8f)
        {
            pos.x = 2.8f; // (+2.8,-2.7,0)
        }
        // 비행기의 위치 = 보정한 값.
        transform.position = pos;
    }

    public void MovementLimit2()
    {
        // 비행기의 위치 값을 가져옴.
        Vector3 pos = this.transform.position; // 위치값(-5,-2.7,0)을 가져온거지 "비행기의 위치" 그자체를 가져온 것이 아님. 위치 "값"을 보정


        // 위치 값을 뷰포트로 전환
        Vector2 posToView = Camera.main.WorldToViewportPoint(pos); //(-0.1,2)

        // 위치 " 값 "을 보정
        if (posToView.x < 0)
        {
            posToView.x = 0;
        }
        if (posToView.x > 1)
        {
            posToView.x = 1;
        }
        // 보정한 값을 월드 좌표로 전환 
        Vector3 final = Camera.main.ViewportToWorldPoint(posToView);
        final.z = 0;


        // 비행기의 위치 = 월드 좌표 전환 값
        transform.position = final;
    }
}
