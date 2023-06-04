using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubstractCantidad : MonoBehaviour
{
    public TextMeshProUGUI cantidad;
    public TextMeshProUGUI mensualidad;
    public void TaskOnClick(){
		if (Points.cantidadPrestamo > 0)  {
            Points.cantidadPrestamo = Points.cantidadPrestamo - 100;
            cantidad.GetComponent<TextMeshProUGUI> ().text = "$" + Points.cantidadPrestamo.ToString ();
            int mens = (int)Points.cantidadPrestamo / 10;
            double interes = Points.cantidadPrestamo * 0.08;
            mens = mens + (int)interes;
            mensualidad.GetComponent<TextMeshProUGUI> ().text = "$" + mens.ToString ();
        } 
	}
}
