using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class VenderMB : MonoBehaviour
{
    public TextMeshProUGUI pActual;
    public TextMeshProUGUI nVender;
    public TextMeshProUGUI presupuesto;
    public TextMeshProUGUI nA;

    void Start()
    {
        Points.auxVentaMB = 0;
        pActual.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.precioMB.ToString();
        nVender.GetComponent<TextMeshProUGUI> ().text = Points.auxVentaMB.ToString();
        nA.GetComponent<TextMeshProUGUI> ().text = Points.cantidadMB.ToString();
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
    }

    void Update(){
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
        pActual.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.precioMB.ToString();
        nA.GetComponent<TextMeshProUGUI> ().text = Points.cantidadMB.ToString();
    }

    public void TaskOnClickAdd(){
        if (Points.cantidadMB > Points.auxVentaMB){
            Points.auxVentaMB = Points.auxVentaMB + 5;
            nVender.GetComponent<TextMeshProUGUI> ().text = Points.auxVentaMB.ToString();
        }
	}

    public void TaskOnClickSubstract(){
        if (Points.auxVentaMB > 0){
            Points.auxVentaMB = Points.auxVentaMB - 5;
            nVender.GetComponent<TextMeshProUGUI> ().text = Points.auxVentaMB.ToString();
        }
	}

    public void TaskOnClickVender(){
        if (Points.auxVentaMB > 0)    
            Points.totalBudget = Points.totalBudget + (Points.auxVentaMB * Points.precioMB);
            Points.cantidadMB = Points.cantidadMB - Points.auxVentaMB;
            presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
            Points.auxVentaMB = 0;
            nVender.GetComponent<TextMeshProUGUI> ().text = Points.auxVentaMB.ToString();
            Debug.Log(Points.cantidadMB);
    }
}
