using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // 리스트를 사용하면 여러개의 데이터를 하나의 변수에 담을 수 있다.
    // public List<데이터타입> 이름 = new List<데이터 타입> { 값1, 값2, 값3 };
    // Q. 사과, 딸기, 바나나
    public List<int> expLV = new List<int> { 100, 200, 300 };

    public List<string> fruits = new List<string> { "사과", "딸기", "바나나" };

    void Start()
    {
        Debug.Log(fruits[0]); // 번호는 반드시 0부터 시작
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("작동" + collision.gameObject.name);
    }


}
