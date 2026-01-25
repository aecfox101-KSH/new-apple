using UnityEngine;

public class Square : MonoBehaviour
{
    // 일반 충돌 + 트리거 충돌은 모두 적용 가능
    // 잠깐알아둘것 :
    // 부딪힌 녀석의 정보의 데이터타입이 다름
    // 따라서 gameObject로 한번 거쳐줘야할때 있음.
    private void OnCollisionEnter2D(Collision2D collision)  //일반 충돌 - Collision2D 매개변수
    {
        Debug.Log("SquareCollision" + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision) // 트리거 충돌 - Collider2D 매개변수
    {
        Debug.Log("SquareTrigger" + collision.name);
    }
}
