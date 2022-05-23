using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public int maxDistance;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 8;

        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, maxDistance,
                layerMask))
        {
            Debug.Log("Hit object");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * maxDistance, Color.blue);
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
                Debug.Log("Jump");
            }
        }
        else
        {
            Debug.Log("Did not hit object");
        }
    }
}