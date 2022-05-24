using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public float maxDistance = 2.0f;
    public int counter = 2;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
       RayCastJump();
       // setup a counter
       // allow player two jumps
       // player stops jumping when player runs out of jumps
       //player can jump again when player touches ground 

    }

    private void RayCastJump()
    {
         int layerMask = 1 << 8;
        
                RaycastHit hit;
                
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * maxDistance, Color.green);
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, maxDistance,
                        layerMask))
                {
                    Debug.Log("Hit object");
                    
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