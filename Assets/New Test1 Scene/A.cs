using UnityEngine;

public class A : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("부딪혔다!" + collision.gameObject.name);
    }
}
