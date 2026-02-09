using UnityEngine;
public class Move0208 : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D rb;

    private float moveSpeed = 6.0f;

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(hori, vert) * moveSpeed;

        // 운석의 위치값
        Vector3 pos = this.gameObject.transform.position;
        if (pos.x < -2.5f)
        {
            pos.x = -2.5f;
        }
        if (pos.x > 2.5f)
        {
            pos.x = 2.5f;
        }
        if (pos.y < -2.5f)
        {
            pos.y = -2.5f;
        }
        if (pos.y > 2.5f)
        {
            pos.y = 2.5f;
        }

        this.gameObject.transform.position = pos;
    }
}
