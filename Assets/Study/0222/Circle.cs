using UnityEngine;

public class Circle : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector2(hori, vert) * moveSpeed;

    }
}
