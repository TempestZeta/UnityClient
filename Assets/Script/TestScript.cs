using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Transform Forward is " + transform.forward);

        Rigidbody rigid = GetComponent<Rigidbody>();
        if (null != rigid)
            rigid.AddForce(transform.forward * 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
