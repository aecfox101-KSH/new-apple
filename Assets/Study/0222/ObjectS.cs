using System.Collections.Generic;
using UnityEngine;

public class ObjectS : MonoBehaviour
{
    // 화면에
    // 원을 하나 복제.
    public GameObject circle;
    public List<GameObject> objects;
    public float time_current = 0;
    public float time_limit = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time_current += Time.deltaTime;
        if(time_current > time_limit)
        {
            time_current = 0;
            MakeOBJ();
        }
    }

    void MakeOBJ()
    {
        // 오브젝트 생성
        // Instantiate(오브젝트, 위치, 회전) 복제
        Vector3 pos = new Vector3(Random.Range(-2.8f, +2.8f), 5, 0);
        Instantiate(objects[Random.Range(0,3)], pos, Quaternion.identity);
    }
}
