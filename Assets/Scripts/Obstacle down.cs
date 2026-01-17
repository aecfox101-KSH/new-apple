using UnityEngine;

public class Obstacledown : MonoBehaviour
{
    public Rigidbody2D rb;
    [Range(0, 10)] public float moveSpeed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = new Vector2(0, -1) * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
