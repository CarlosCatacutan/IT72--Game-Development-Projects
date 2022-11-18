using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carlos : MonoBehaviour
{
Rigidbody rb;
    float movementspeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity =new Vector3(horizontalInput * movementspeed ,rb.velocity.y,verticalInput * movementspeed);
        
       
    }
}