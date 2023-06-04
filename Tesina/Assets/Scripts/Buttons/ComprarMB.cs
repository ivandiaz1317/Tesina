using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ComprarMB : MonoBehaviour
{
    int randomNumber;
    int cantidad;
    System.Random RNG = new System.Random();
    public TextMeshProUGUI pActual;
    public TextMeshProUGUI nComprar;
    public TextMeshProUGUI presupuesto;
    // Start is called before the first frame update
    void Start()
    {
        cantidad = 0;
        randomNumber = RNG.Next(5,51);
        Points.precioMB = randomNumber;
        Points.auxMB = 0;
        pActual.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.precioMB.ToString();
        nComprar.GetComponent<TextMeshProUGUI> ().text = cantidad.ToString();
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
    }

    void Update(){
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
    }

    public void TaskOnClickAdd(){
        Points.auxMB = Points.auxMB + 5;
        nComprar.GetComponent<TextMeshProUGUI> ().text = Points.auxMB.ToString();
	}

    public void TaskOnClickSubstract(){
        if (Points.auxMB > 0){
            Points.auxMB = Points.auxMB - 5;
            nComprar.GetComponent<TextMeshProUGUI> ().text = Points.auxMB.ToString();
        }
	}

    public void TaskOnClickComprar(){
        if (Points.auxMB > 0){
            if (Points.auxMB * Points.precioMB <= Points.totalBudget){
                
                Points.totalBudget = Points.totalBudget - (Points.auxMB * Points.precioMB);
                Points.cantidadMB = Points.cantidadMB + Points.auxMB;
                presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
                Debug.Log(Points.cantidadMB);
            }
        }
    }
    

}
