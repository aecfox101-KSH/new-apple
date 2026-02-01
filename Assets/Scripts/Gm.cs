using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public int score = 0;
    public int playerLife = 3;
    public List<Image> heartIMGs;
    public GameObject obstacle;
    public float time_current;
    [Range(0,1f)] public float regentime = 1.0f;

    public void MakeObstacle()
    {
        Instantiate(obstacle, new Vector3(Random.Range(-2.8f,+2.8f), 5, 0), Quaternion.identity);
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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        #region Random.Range 학습
        /* Random.Range(a,b)
        a,b가 정수일때 : a ~ "b-1"사이의 정수값
        a,b가 소수일때 : a ~ b 사이의 소수값
         */
        #endregion

        Debug.Log($"정수: {Random.Range(0,3)}, 소수: {Random.Range(0,3f)}");
        // Debug.Log("정수" + Random.Range(0, 3));

        time_current += Time.deltaTime; // 프레임의 역수 
        if (time_current > 1)
        {
            MakeObstacle();
            time_current = 0;
        }
    }
}
