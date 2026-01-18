using System.Collections.Generic;
using UnityEngine;

public class ListNFor : MonoBehaviour
{
    // List<데이터타입> 이름 = {값, 값, 값, 값};
    public List<int> expLVs = new List<int>{ 100, 200, 300, 400 }; // new List<int> 하는 이유 = 새로운 값
    public List<string> words = new List<string> { "가", "나", "다" };

    public List<GameObject> objs = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(expLVs[0]);
        Debug.Log(words[0]);

        // 반복문의 일정
        // 일정횟수만큼 반복
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("실험");
        }
        // int i = 0; i < 3; 코드0 , i = 1;
        // int i = 0; i < 3; 코드1 , i = 2;
        // int i = 0; i < 3; 코드2 , i = 3;
        // int i = 3; i < 3; 코드x

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
