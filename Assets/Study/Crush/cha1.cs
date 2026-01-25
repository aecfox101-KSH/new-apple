using UnityEngine;

public class cha1 : MonoBehaviour
{
    // 스크립트가 부착된 오브젝트가
    // 충돌이 발생했을 때 호출되는 메세지
    // 부딪힌 녀석의 정보가 (Collision2D collision) 형태로 들어옴.
    private void OnCollisionEnter2D(Collision2D collision) // 매개변수로 충돌한 상대방의 정보가 담긴 Collision2D 객체를 받음
    {
        Debug.Log("충돌 발생!" + collision.gameObject.name); // 내가 부딪힌 상대방의 이름을 출력
    }

    // 일반충돌에서 트릭거 메세지를 작동했을 시에는 작동 x
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Debug.Log("잠입");   
    }


}
