using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string MyMessage;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");//ֻ���һ��
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World!");//������
        Debug.Log(MyMessage);
    }
}
