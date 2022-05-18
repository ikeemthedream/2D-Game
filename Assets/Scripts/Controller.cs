using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 10.0f;

    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
       body = GetComponent<Rigidbody>();
    }
    private Vector3 _movement = Vector3.zero;

    // Update is called once per frame
    void Update()
    {        
        _movement = new Vector3(Input.GetAxis("Horizontal"),  Input.GetAxis("Vertical"), 0);
        

    }
    
    private void FixedUpdate()
    {          
        body.MovePosition(body.position + _movement * speed * Time.deltaTime);

    }
}
