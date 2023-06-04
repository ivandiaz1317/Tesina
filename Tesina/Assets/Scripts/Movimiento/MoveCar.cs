using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    Vector3 originalPos;
    Vector3 originalRot;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey (KeyCode.W)) {  
            transform.Translate (0.0f, 0f, .09f);      
        }  
        if (Input.GetKey (KeyCode.S)) {  
            transform.Translate (0.0f, 0f, -.09f);      
        }
        if (Input.GetKey (KeyCode.D)) {  
            transform.Rotate (0.0f, 1.1f, 0f);      
        }  
        if (Input.GetKey (KeyCode.A)) {  
            transform.Rotate (0.0f, -1.1f, 0f);      
        }  
        if (Input.GetKey (KeyCode.R)) {  
            gameObject.transform.position = originalPos; 
            gameObject.transform.rotation = Quaternion.identity;   
        }  
    }
}
