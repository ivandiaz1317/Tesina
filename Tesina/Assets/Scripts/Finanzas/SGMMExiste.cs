using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SGMMExiste : MonoBehaviour
{
    public Button sgmm;
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI bonus;
    public TextMeshProUGUI ingresos;
    public TextMeshProUGUI egresos;
    public TextMeshProUGUI presupuesto;
    public TextMeshProUGUI seguro;

    void Start()
    {
        if (Points.sgmm == true){
           sgmm.gameObject.SetActive(false);
           seguro.GetComponent<TextMeshProUGUI> ().text = "SI";
        }
        Points.totalBudget = Points.totalBudget + Points.incomes - Points.expenses;
        tiempo.GetComponent<TextMeshProUGUI> ().text = Points.time.ToString () + " segundos";
        bonus.GetComponent<TextMeshProUGUI> ().text = "$" + Points.bonus.ToString ();
        ingresos.GetComponent<TextMeshProUGUI> ().text = "$" + Points.incomes.ToString ();
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$" + Points.totalBudget.ToString ();
        egresos.GetComponent<TextMeshProUGUI> ().text = "- $" + Points.expenses.ToString ();
        Debug.Log (Points.scene);
    }

    void Update(){
        if (Points.sgmm == true){
           sgmm.gameObject.SetActive(false);
           seguro.GetComponent<TextMeshProUGUI> ().text = "SI";
        }
        presupuesto.GetComponent<TextMeshProUGUI> ().text = "$" + Points.totalBudget.ToString ();
        egresos.GetComponent<TextMeshProUGUI> ().text = "- $" + Points.expenses.ToString ();
    }


}
