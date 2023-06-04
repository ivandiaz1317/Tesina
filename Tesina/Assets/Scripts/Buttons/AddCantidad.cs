using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddCantidad : MonoBehaviour
{
    public TextMeshProUGUI cantidad;
    public TextMeshProUGUI mensualidad;
    public void TaskOnClick(){
        Points.cantidadPrestamo = Points.cantidadPrestamo + 100;
        cantidad.GetComponent<TextMeshProUGUI> ().text = "$" + Points.cantidadPrestamo.ToString ();
        int mens = (int)Points.cantidadPrestamo / 10;
        double interes = Points.cantidadPrestamo* 0.08;
        mens = mens + (int)interes;
        mensualidad.GetComponent<TextMeshProUGUI> ().text = "$" + mens.ToString ();
	}
}
