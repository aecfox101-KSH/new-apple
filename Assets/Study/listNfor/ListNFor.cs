using System.Collections.Generic;
using UnityEngine;

public class ListNFor : MonoBehaviour
{
    // 값을 적을때는 : {값,값}
    // 개수를 선언할때 : (숫자)
    // ()만 적으면 0개 생성.

    // List<데이터타입> 이름 = {값, 값, 값, 값};
    public List<int> expLVs = new List<int>{ 100, 200, 300, 400 }; // new List<int> 하는 이유 = 새로운 값
    public List<string> words = new List<string> { "가", "나", "다" };

    public List<GameObject> objs = new List<GameObject>();

    public List<int> countA = new List<int> {0}; // 문제1 5개
    public List<int> countB = new List<int> {1}; // 문제2 6개
    public List<string> fruits = new List<string> {""}; // 문제3 3개
    public List<string> toy = null; // 문제4 5개

    public List<int> test = new List<int>(new int [5]);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(expLVs[0]);
        Debug.Log(words[0]);

        // 반복문의 일정
        // 일정횟수만큼 반복
        for (int i = 0; i < expLVs.Count; i++)
        {
            Debug.Log("실험" + i);
            expLVs[i] = 500 + 1000 * i;
            
        }

        // 500 + 1000 * 0
        // 500 + 1000 * 1
        // 500 + 1000 * 2

        // int i = 0; i < 3; 코드0 , i = 1;
        // int i = 0; i < 3; 코드1 , i = 2;
        // int i = 0; i < 3; 코드2 , i = 3;
        // int i = 3; i < 3; 코드x


        for(int i = 0; i < countA.Count; i++)
        {
            countA[i] = i * 5;
        }

        for (int i = 0; i < countB.Count; i++)
        {
            countB[i] = 5 + i * 5;
        }

        for (int i = 0; i < fruits.Count ; i++)
        {
            fruits[i] = "딸기";
        }

        for( int i = 0;i < toy.Count; i++)
        {
            toy[i] = "피젯스피너";
        }

    }

}
