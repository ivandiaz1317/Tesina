using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PurchaseSGMM : MonoBehaviour
{
    public TextMeshProUGUI texto;


    public void TaskOnClick(){
        if (Points.totalBudget < 1000){
           texto.GetComponent<TextMeshProUGUI> ().text = "No tienes suficiente dinero para comprar el seguro, si lo deseas, puedes pedir un prestamo para poder adquirirlo";
        }else{
            Points.totalBudget = Points.totalBudget - 1000;
            Points.sgmm = true;
        }
	}

}
