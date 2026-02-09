using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public int score;
    public Text A;
    public GameObject gameOverWindow;
    public Text overWindowScore;

    public int playerLife = 3;
    public List<Image> heartIMGs;

    public GameObject obstacle;
    public float time_current;
    [Range(0,1f)] public float regentime = 1.0f;

    public void MakeObstacle()
    {
        Instantiate(obstacle, new Vector3(Random.Range(-2.8f,+2.8f), 5, 0), Quaternion.identity); // Instantiate 복제
    }
    public void MakeObstacle2()
    {
        Vector2 pos = new Vector2(Random.Range(0, 1f), 1.1f);
        Vector3 posToWorld= Camera.main.ViewportToWorldPoint(pos);
        posToWorld.z = 0; // 카메라에 안보여서 z 축 = 0 으로 표시

        Instantiate(obstacle, posToWorld, Quaternion.identity);
    }

    public void UpdateHeartUI()
    {
        /* 가정 
         * PlayerLife = 2
         * 
         * heartMGs[0] = 빨간색
         * heartMGs[1] = 빨간색
         * heartMGs[2] = 검정색
         */

        //playerLife = 2, i <= 1
        //playerLife = 1, i <= 0

        for (int i = 0; i < heartIMGs.Count; i++)
        {
            if (i <= playerLife -1)
            {
                heartIMGs[i].color = new Color(1, 1, 1);
                // heartIMGs[i].color = Color.white;
            }
            else
            {
                heartIMGs[i].color = new Color(0, 0, 0);
                // heartIMGs[i].color = Color.black;
            }

        }
    }

    public void UpdateScoreUI()
    {
        A.text = score.ToString();
    }

    void ReStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameOver()
    {
        //최고점수가 있는지 확인
        //점수가 있을경우
        if (PlayerPrefs.HasKey("BestScore") == true)
        {
            //획득한점수가, 최고점수보다 크면
            if (score > PlayerPrefs.GetInt("BestScore"))
            {
                //최고점수를 획든한 점수로 갱신
                PlayerPrefs.SetInt("BestScore", score);
            }
        }
        else//점수가 없을경우
        {
            //최고점수 = 획득한 점수
            PlayerPrefs.SetInt("BestScore", score);
        }

        //최고점수를 화면에 띄우기
        //\n 줄바꿈
        overWindowScore.text = $"BestScore\n{PlayerPrefs.GetInt("BestScore")}";

        //게임종료창 활성화
        gameOverWindow.SetActive(true);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {       
        UpdateScoreUI();

        if (Input.GetKeyDown(KeyCode.R))
        {
            ReStart();  
        }

        #region Random.Range 학습
        /* Random.Range(a,b)
        a,b가 정수일때 : a ~ "b-1"사이의 정수값
        a,b가 소수일때 : a ~ b 사이의 소수값
         */
        #endregion

        // Debug.Log($"정수: {Random.Range(0,3)}, 소수: {Random.Range(0,3f)}");
        // Debug.Log("정수" + Random.Range(0, 3));

        time_current += Time.deltaTime; // 프레임의 역수 
        if (time_current > 1)
        {
            MakeObstacle2();
            time_current = 0;
        }
    }
}
