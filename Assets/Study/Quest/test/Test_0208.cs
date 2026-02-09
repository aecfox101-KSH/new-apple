using UnityEngine;


public class Test_0208 : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D rb;

    public GameObject circle;

    public float time_current;

    // Update is called once per frame
    void Update()
    {
        float rangeX = Random.Range(-2f, 2f);
        float rangeY = Random.Range(-2f, 2f);

        Vector3 pos = new Vector3(rangeX,rangeY,0);

        time_current += Time.deltaTime; 
        if (time_current > 1)
        {
            Instantiate(circle, pos, Quaternion.identity);
            time_current = 0;
        }
    }
}
