using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject testObj;
    public GameObject ballPrefab;
    public float forcePower=10;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            var rb = testObj.GetComponent<Rigidbody>();
            
            rb.AddForce(0,10,0);
        }

        if (Input.GetKeyUp(KeyCode.Tab))
        {
            Instantiate(ballPrefab, new Vector3(0, 5f, 0), Quaternion.identity);
        }
    }
}
