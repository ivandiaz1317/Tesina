using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveandJump : MonoBehaviour
{
    public float jumpSpeed = 5000f;
    Rigidbody rb;
    public System.DateTime startTime;
   void Start()
    {
        rb = GetComponent<Rigidbody>();
        startTime = System.DateTime.UtcNow;
    }

 
    // Update is called once per frame
    void Update()
    {
        //GameObject.Find("Personaje").GetComponent<SceneController1>().ChangeScene();
         if (Input.GetKey (KeyCode.W)) {  
            transform.Translate (0.0f, 0f, .085f);      
        }  
        if (Input.GetKey (KeyCode.S)) {  
            transform.Translate (0.0f, 0f, -.085f);      
        }  
        if (Input.GetKey (KeyCode.D)) {  
            transform.Translate (.085f, 0f, 0f) ;     
        }  
        if (Input.GetKey (KeyCode.A)) {  
            transform.Translate (-.085f, 0f, 0f);      
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
