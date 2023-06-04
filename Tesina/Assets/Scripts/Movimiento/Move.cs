using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move up
         if (Input.GetKey (KeyCode.W)) {  
            transform.Translate (0.0f, 0f, .08f);      
        } //Move down 
        if (Input.GetKey (KeyCode.S)) {  
            transform.Translate (0.0f, 0f, -.08f);      
        }  //Move rigth
        if (Input.GetKey (KeyCode.D)) {  
            transform.Translate (.08f, 0f, 0f) ;     
        }  //Move left
        if (Input.GetKey (KeyCode.A)) {  
            transform.Translate (-.08f, 0f, 0f);      
        } 
    }
}
