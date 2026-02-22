using System.Collections.Generic;
using UnityEngine;

// 적 오브젝트를 생성
// 인벤토리 시스템 구현

public class Study : MonoBehaviour
{
    // List : 여러개의 변수를 다루기 위해 사용
    // int 1개를 다루고; 싶음 -> int num = 10;
    // int 10개를 다루고 싶음 -> int Num{1,2 ~ 10}

    [Header("List")]
    public List<int> peopleAge = new List<int>() { 10, 20 ,30, 40, 50 };
    public List<string> peopleName;
    public List<string> fruits = new List<string>(new string [5]);
    public List<string> Item;

    public List<int> lvExp = new List<int>(new int[10]);

    // 문제 List and for문 활용
    public List<int> counts = new List<int>(new int[8]);

    // Array: 배열
    //  여러개의 값들을 사용하기 위해
    // 추가 / 제거 x -> List 는 가능
    // 크기는 새롭게 지정할 수 있음.
    // 생성 및 초기화는 가능

    [Header("Array")]
    // 1차원 배열 : 1줄로 이루어진 형태
    public int[] damaged = { 50 , 100, 150 };
    // 2차원 배열 : 1차원 배열이 여러개 모인 형태
    public int[,] damaged2 =
    {
        { 50 , 100, 150 },      // Element 0 , 0,1,2 순
        { 150 , 1100, 1150 },   // Element 1 , 0,1,2 순
        { 250 , 2100, 2150 },   // Element 2 , 0,1,2 순
        { 350 , 3100, 3150 }    // Element 3 , 0,1,2 순
    };
    // 예시) [행,열] 순서 : 3명의 학생, 3개의 과목 점수 
    int[,] grades = new int[3,3]
    {    
        { 90, 80, 70 },     // 학생 1의 국어, 영어, 수학 점수 (국, 영, 수)
        { 85, 75, 65 },     // 학생 2의 국어, 영어, 수학 점수
        { 95, 85, 75 }      // 학생 3의 국어, 영어, 수학 점수
    };
    // 0: 갈 수 있는 길, 1: 벽 // 예시) 5x5 게임 맵
    int[,] gameMap = 
    {
    { 1, 1, 1, 1, 1 },
    { 1, 0, 0, 0, 1 },
    { 1, 0, 1, 0, 1 },
    { 1, 0, 0, 0, 1 },
    { 1, 1, 1, 1, 1 }
    };
    //3 차원 배열 : 2차원 배열이 여러개 모인 형태

    // Array문제 
    public string[]items = { "sword", "shield", "potion" };


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StudyList_For();
        StudyArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StudyList_For()
    {
        // List
        // 값을 추가/제거

        // 추가
        peopleAge.Add(100);

        // 제거
        peopleAge.Remove(20); // 값을 제거
        peopleAge.RemoveAt(3); // Element를 기준으로 제거 = 인덱스 번호로 제거
        peopleAge.Clear(); // 전체 제거

        peopleAge = new List<int>(new int[4]); // List<int> peopleAge = new List<int>() { 0, 0, 0, 0 }; 와 동일

        for (int i = 0; i < 3; i++)
        {
            peopleName.Add("");
        }
        peopleName.Add("지민");

        fruits[2] = "apple";

        Item.Add("sword");

        // 퀘스트 : 체리를 2번째로 먹기 

        // for: 일정횟수만큼 반복문
        for (int i = 0; i < lvExp.Count; i++)
        {
            lvExp[i] = 30 + 50 * i;
        }
        // lvExp[0] = 30 + 50 * 0;
        // lvExp[1] = 30 + 50 * 1;
        // lvExp[2] = 30 + 50 * 2;

        // int i = 0; i < 3; 코드 실행 0, i = 1;
        // int i = 1; i < 3; 코드 실행 0, i = 2;
        // int i = 2; i < 3; 코드 실행 0, i = 3;
        // int i = 3; i < 3; 코드 실행 x

        // List and for문 활용 문제
        for (int i = 0; i < counts.Count; i++)
        {
            counts[i] = 6 + 7 * i;
        }
    }

    public void StudyArray()
    {
        // Array
        Debug.Log(damaged[2]);
        damaged = new int[5];
        damaged = new int[] { 1, 2, 3, 4, 5 };

        // Array문제
        // items = new string[] { "sword", "shield", "bow", "potion", "arrow"};
        items = new string[5];
        items[3] = "포션";
    }
}
