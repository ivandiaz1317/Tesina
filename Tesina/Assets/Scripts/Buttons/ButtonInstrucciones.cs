using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInstrucciones : MonoBehaviour
{
    public Canvas actual;
    public Canvas instrucciones;
    


    // Update is called once per frame
    public void TaskOnClick(){
        Canvas cActual = actual.GetComponent<Canvas>();
        Canvas cInstrucciones = instrucciones.GetComponent<Canvas>();
		Debug.Log ("You have clicked the button!");
        cInstrucciones.enabled = true;
        cActual.enabled = false;
	}
}
