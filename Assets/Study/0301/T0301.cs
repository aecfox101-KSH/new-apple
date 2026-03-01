using UnityEngine;
using System.Collections.Generic; // List 사용

public class T0301 : MonoBehaviour
{
    // List<데이터타입>이름 = {값, 값}
    public List<int> expLV = new List<int>() { 50, 100, 150, 200 };
    public int[] a = { 10, 20, 30 }; // 1차원 배열
    public int[ , ] a2 = { { 10, 20, 30 }, { 10, 20, 30 }, { 10, 20, 30 } }; // 2차원 배열

    public int[ , , ] a3 = { { { 10, 20, 30 }, { 10, 20, 30 }, { 10, 20, 30 } },
                             { { 10, 20, 30 }, { 10, 20, 30 }, { 10, 20, 30 } },
                             { { 10, 20, 30 }, { 10, 20, 30 }, { 10, 20, 30 } } }; // 3차원 배열

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 배열은 추가 / 제거 x -> List 는 가능
        // 배열은 값을 재설정 가능함.(초기화)
        a = new int[] { 1, 2, 3, 4, 5 };
        a = new int[4]; 


        // 제거 : Element , 값 (2가지 방법)
        expLV.RemoveAt(3);
        expLV.Remove(50);

        // 추가
        expLV.Add(1000);
 
        // 초기화
        expLV = new List<int>(); // 생성시 아무것도 없는 것
        expLV = new List<int>() { 1000, 2000, 3000, 4000 }; // 생성과 동시에 초기화
        expLV = new List<int>(new int[5]); // 개수만 지정해서 생성


        // 숫자만큼 코드 실행
        for (int i = 0; i < 3; i++)
        {
            expLV[i] = 1000;
        }


        // int i = 0; i < 3; 코드 실행 0, i = 1;
        // int i = 1; i < 3; 코드 실행 0, i = 2;
        // int i = 2; i < 3; 코드 실행 0, i = 3;
        // int i = 3; i < 3; 코드 실행 x


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
