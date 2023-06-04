using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMoveandJump : MonoBehaviour
{
    public float jumpSpeed = 5000f;
    Rigidbody rb;
    public System.DateTime startTime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startTime = System.DateTime.UtcNow;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey (KeyCode.W)) {  
            transform.Translate (0.0f, 0f, .07f);      
        }  
        if (Input.GetKey (KeyCode.S)) {  
            transform.Translate (0.0f, 0f, -.07f);      
        }  
        if (Input.GetKey(KeyCode.Space))
        {
            System.TimeSpan ts = System.DateTime.UtcNow - startTime;
            if (ts.Seconds > 0){
                startTime = System.DateTime.UtcNow;
                rb.AddForce(0f, jumpSpeed , 0f);
                //rb.AddForce(0f, jumpSpeed * Time.deltaTime, 0f);
            }
        }
    }
}
