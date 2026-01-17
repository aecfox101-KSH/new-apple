using UnityEngine;

public class Lemon : MonoBehaviour
{
    public Rigidbody2D lemoRB;
    public float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ÄÚµå´Â Â÷·Ê´ë·Î ½ÇÇàµÊ.
        float Hori = Input.GetAxis("Horizontal");
        float Vert = Input.GetAxis("Vertical");

        lemoRB.linearVelocity = new Vector2(Hori, Vert) * moveSpeed; 

    }
}
