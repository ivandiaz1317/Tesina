using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class Accidente : MonoBehaviour
{
    int cantidad;
    int gravedad;
    int deducible = 300;
    System.Random RNG = new System.Random();
    public TextMeshProUGUI sgmm;
    public TextMeshProUGUI texto;
    public TextMeshProUGUI costo;
    public TextMeshProUGUI costoFinal;

    void Start()
    {
        gravedad = RNG.Next(1,7);
        if (gravedad < 4){
            cantidad = RNG.Next(400,701);
            costo.GetComponent<TextMeshProUGUI> ().text = "$" + cantidad.ToString ();
            texto.GetComponent<TextMeshProUGUI> ().text = "Sufriste un esguince tobillo mientras jugabas futbol con tus amigos. Afortunadamente no fue nada grave y solo necesitas rehabilitación";
        }else if ( gravedad < 6){
            cantidad = RNG.Next(701,1701);
            costo.GetComponent<TextMeshProUGUI> ().text = "$" + cantidad.ToString ();
            texto.GetComponent<TextMeshProUGUI> ().text = "Sufriste una caida de las escaleras de tu casa. Aunque no fue nada muy grave, si tuviste una fractura en tu brazo, que además requiere rehabilitación";
        }else{
            if (Points.totalBudget > 1701 ){
                cantidad = RNG.Next(1701, Points.totalBudget - 200);
            }else{
                cantidad = RNG.Next(1701, 4000);
            }
            costo.GetComponent<TextMeshProUGUI> ().text = "$" + cantidad.ToString ();
            texto.GetComponent<TextMeshProUGUI> ().text = "Sufriste un accidente de auto muy grave. Te lesionaste la pierna y ambos brazos, además de que requeriste cirugía.";
        }

        if (Points.sgmm == true){
            double aux;
            sgmm.GetComponent<TextMeshProUGUI> ().text = "Si";
            aux = (cantidad - deducible) * .1;
            cantidad = deducible + (int) aux;
            costoFinal.GetComponent<TextMeshProUGUI> ().text = "$" + cantidad.ToString ();
           
        }else{
            costoFinal.GetComponent<TextMeshProUGUI> ().text = "$" + cantidad.ToString ();
        }

    }

    public void TaskOnClick(){
        Points.totalBudget = Points.totalBudget - cantidad;
        SceneManager.LoadScene("Finanzas");
	}

}
