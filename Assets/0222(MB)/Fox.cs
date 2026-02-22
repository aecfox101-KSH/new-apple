using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    public List<string> itemList;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("item"))
        {
            // 오직 아이템들만 itemList에 등록
            itemList.Add(collision.name);
        }
    }
}
