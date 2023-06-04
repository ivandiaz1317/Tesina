using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PedirPrestamo : MonoBehaviour
{
    public Canvas actual;
    public Canvas target;

    public void TaskOnClick(){
        double interes = Points.cantidadPrestamo * 0.08;
        int mens = (int)Points.cantidadPrestamo / 10;
         mens = mens + (int)interes;
        Points.mensualidadPrestamo = Points.mensualidadPrestamo + mens;
        Points.expenses = Points.expenses + mens;
        Points.totalBudget = Points.totalBudget + Points.cantidadPrestamo;
        Points.cantidadPrestamo = 100;
        Canvas cActual = actual.GetComponent<Canvas>();
        Canvas cTarget = target.GetComponent<Canvas>();
		Debug.Log ("You have clicked the button!");
        cTarget.enabled = true;
        cActual.enabled = false;
	}
}
