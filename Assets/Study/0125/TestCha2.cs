using UnityEngine;

public class TestCha2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TriggerEnter2D");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("TriggerStay2D");
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("TriggerExit2D");
    }
}
