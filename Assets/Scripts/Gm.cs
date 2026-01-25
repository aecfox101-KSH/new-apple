using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public int score = 0;
    public int playerLife = 3;
    public List<Image> heartIMGs; 

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
        
    }
}
