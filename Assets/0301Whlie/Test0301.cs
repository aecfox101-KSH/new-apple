using UnityEngine;

public class Test0301 : MonoBehaviour
{
    // public 외부 사용 o
    // private 외부 사용 x 
    // [SerializeField] : 외부에서 사용x 인스펙터창에서는 확인 가능.

    [SerializeField]
    public Study0301 scriptStudy;
    // *public으로 선언한 변수만 외부에서 사용 가능.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // scriptStudy.eMap; 
        // scriptStudy.a;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
