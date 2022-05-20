using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody _body;
    private float _run;
    
    
    // Start is called before the first frame update
    void Start()
    {
       _body = GetComponent<Rigidbody>();
       _run = Input.GetAxis("Horizontal");
       
    }
    private Vector3 _movement = Vector3.zero;

    // Update is called once per frame
    void Update()
    {        
        _movement = new Vector3(Input.GetAxis("Horizontal"),  0, 0);
        
    }
    
    private void FixedUpdate()
    {          
        _body.MovePosition(_body.position + _movement * (speed * Time.deltaTime));
    }

    
}
