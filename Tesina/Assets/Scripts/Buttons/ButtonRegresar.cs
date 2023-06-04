using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRegresar : MonoBehaviour
{
    public Canvas actual;
    public Canvas target;
    


    // Update is called once per frame
    public void TaskOnClick(){
        Canvas cActual = actual.GetComponent<Canvas>();
        Canvas ctarget = target.GetComponent<Canvas>();
		Debug.Log ("You have clicked the button!");
        ctarget.enabled = true;
        cActual.enabled = false;
	}
}
