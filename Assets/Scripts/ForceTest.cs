using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTest : MonoBehaviour
{
    public Vector3 force = Vector3.zero;
    public Vector3 torque = Vector3.zero;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(force);
            transform.Rotate(torque);
            Debug.Log("test");
        }

    }
}
