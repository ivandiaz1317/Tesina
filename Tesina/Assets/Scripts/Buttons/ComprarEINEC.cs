using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ComprarEINEC : MonoBehaviour
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
        randomNumber = RNG.Next(3,31);
        Points.precioEINEC = randomNumber;
        Points.auxEINEC = 0;
        pActual.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.precioEINEC.ToString();
        nComprar.GetComponent<TextMeshProUGUI> ().text = cantidad.ToString();
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
    }

    void Update(){
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
    }

    public void TaskOnClickAdd(){
        Points.auxEINEC = Points.auxEINEC + 5;
        nComprar.GetComponent<TextMeshProUGUI> ().text = Points.auxEINEC.ToString();
	}

    public void TaskOnClickSubstract(){
        if (Points.auxEINEC > 0){
            Points.auxEINEC = Points.auxEINEC - 5;
            nComprar.GetComponent<TextMeshProUGUI> ().text = Points.auxEINEC.ToString();
        }
	}

    public void TaskOnClickComprar(){
        if (Points.auxEINEC > 0){
            if (Points.auxEINEC * Points.precioEINEC <= Points.totalBudget){
                
                Points.totalBudget = Points.totalBudget - (Points.auxEINEC * Points.precioEINEC);
                Points.cantidadEINEC = Points.cantidadEINEC + Points.auxEINEC;
                presupuesto.GetComponent<TextMeshProUGUI> ().text = "$ " + Points.totalBudget.ToString();
                Debug.Log(Points.cantidadEINEC);
            }
        }
    }
}
