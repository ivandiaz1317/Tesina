using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigateCanvas : MonoBehaviour
{
    public Canvas actual;
    public Canvas target;
    


    // Update is called once per frame
    public void TaskOnClick(){
        Canvas cActual = actual.GetComponent<Canvas>();
        Canvas cTarget = target.GetComponent<Canvas>();
		Debug.Log ("You have clicked the button!");
        cTarget.enabled = true;
        cActual.enabled = false;
	}
}
