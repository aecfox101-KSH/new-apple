using UnityEngine;

public class T0208 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 뷰포트 -> 월드좌표로 바꿔줌
        Vector2 pos = new Vector2 (1, 0.5f);
        Vector3 posToWorld = Camera.main.ViewportToWorldPoint (pos);
        posToWorld.z = 0;
        // 오브젝트 위치 = 월드좌표
        this.gameObject.transform.position = posToWorld;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
