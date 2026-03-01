using UnityEngine;
using UnityEngine.UI;

public class Study0301 : MonoBehaviour
{
    [SerializeField] private int a = 3;

    public Text info;
    // public Text openMap;

    // enum 일종의 열거형 상자 느낌으로 인식.
    public enum State { idle, walk,chased ,dead };
    public State estate = State.idle;

    public enum Map { 도라도, 주미온, 테르미온 }
    public Map eMap = Map.도라도;

    public enum Job {프로그래머, 디자이너, 기획자}
    public Job eJob = Job.프로그래머;
    // 만약에 public Job eJob; 적을시 맨앞에 있는 값이 출력됨. 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "영희";
        switch(name)
        {
            case "영희":
                Debug.Log("영희가 집에 왔다.");
                break;
            case "철수":
                Debug.Log("영희 친구가 놀러왔다.");
                break;
            default:
                Debug.Log("모르는 사람이다.");
                break;
        }


        //enum 학습
        Debug.Log(estate.ToString()+(int)estate);

        #region While문
        // *무한루프에 빠지지 않도록 주의
        // 대표적인 방법
        // - break; 조건문, 반복문을 종료
        // - return; 함수를 종료
        while (2<3)
        {
            Debug.Log("work");
            break;
        }
        Debug.Log("work2");
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Potal()
    {
        /*if(estate == State.chased)
        {
            info.text = "쫒기는 중에는 \n 이동이 불가능합니다.";

        }
        else if(estate == State.dead)
        {
            info.text = "사망상태에서는 \n 이동이 불가능합니다.";
        }
        else
        {
            info.text = "이동완료";
        }*/

        /*if (eMap == Map.테르미온)
        {
            openMap.text = "테르미온에 입장했습니다. \n 테르미온의 영광을!";
        }
        else if (eMap == Map.주미온)
        {
            openMap.text = "주미온에 입장했습니다. \n 빛과 함께이길...";
        }
        else
        {
            openMap.text = "도라도에 입장했습니다. \n 도라도와 함께 떠나요!";
        }*/

        /*switch (estate)
        {
            case State.chased:
                info.text = "쫒기는 중에는 \n 이동이 불가능합니다.";
                break;
            case State.dead:
                info.text = "쫒기는 중에는 \n 이동이 불가능합니다.";
                break;
            default:
                info.text = "포탈이동 완료";
                break ;
        }*/
        

        switch (eMap)
        {
            case Map.도라도:
                info.text = "테르미온에 입장했습니다. \n 테르미온의 영광을!";
                break;
            case Map.주미온:
                info.text = "주미온에 입장했습니다. \n 빛과 함께이길...";
                break;
            case Map.테르미온:
                info.text = "도라도에 입장했습니다. \n 도라도와 함께 떠나요!";
                break;
        }


    }

}
