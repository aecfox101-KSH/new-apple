using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject circle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate(오브젝트,위치,회전)
        Instantiate(circle, new Vector3(0,0,0), Quaternion.identity);  
        
    }
}
