using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class VenderEINEC : MonoBehaviour
{
    public TextMeshProUGUI pActual;
    public TextMeshProUGUI nVender;
    public TextMeshProUGUI presupuesto;
    public TextMeshProUGUI nA;

    void Start()
    {
        Points.auxVentaEINEC = 0;
        pActual.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.precioEINEC.ToString();
        nVender.GetComponent<TextMeshProUGUI> ().text = Points.auxVentaEINEC.ToString();
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
        nA.GetComponent<TextMeshProUGUI> ().text = Points.cantidadEINEC.ToString();
    }

    void Update(){
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
        pActual.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.precioEINEC.ToString();
        nA.GetComponent<TextMeshProUGUI> ().text = Points.cantidadEINEC.ToString();
    }

    public void TaskOnClickAdd(){
        if (Points.cantidadEINEC > Points.auxVentaEINEC){
            Points.auxVentaEINEC = Points.auxVentaEINEC + 5;
            nVender.GetComponent<TextMeshProUGUI> ().text = Points.auxVentaEINEC.ToString();
        }
	}

    public void TaskOnClickSubstract(){
        if (Points.auxVentaEINEC > 0){
            Points.auxVentaEINEC = Points.auxVentaEINEC - 5;
            nVender.GetComponent<TextMeshProUGUI> ().text = Points.auxVentaEINEC.ToString();
        }
	}

    public void TaskOnClickVender(){
        if (Points.auxVentaEINEC > 0)    
            Points.totalBudget = Points.totalBudget + (Points.auxVentaEINEC * Points.precioEINEC);
            Points.cantidadEINEC = Points.cantidadEINEC - Points.auxVentaEINEC;
            presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
            Points.auxVentaEINEC = 0;
            nVender.GetComponent<TextMeshProUGUI> ().text = Points.auxVentaEINEC.ToString();
            Debug.Log(Points.cantidadEINEC);
    }
}
