using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Final : MonoBehaviour
{
    public TextMeshProUGUI regla1;
    public TextMeshProUGUI regla2;
    public TextMeshProUGUI regla3;
    public TextMeshProUGUI egresos;
    public TextMeshProUGUI saldo;
    bool reg1 = true;
    bool reg2 = true;
    void Start()
    {
        egresos.GetComponent<TextMeshProUGUI> ().text = "$" + Points.expenses.ToString();
        saldo.GetComponent<TextMeshProUGUI> ().text = "$" + Points.totalBudget.ToString();
        if(Points.incomes > Points.expenses){
            regla1.GetComponent<TextMeshProUGUI> ().text = "Felicidades, lograste que tus egresos se mantuvieran por debajo de tus ingresos.";
        }else{
            regla1.GetComponent<TextMeshProUGUI> ().text = "Lamentablemente no pudiste mantener tus egresos por debajo de tus ingresos.";
            reg1 = false;
        }
        if(Points.totalBudget >= 10000){
            regla2.GetComponent<TextMeshProUGUI> ().text = "Felicidades, lograste alcanzar los $10000 de saldo para poder comprar tu motocicleta.";
        }else{
            regla2.GetComponent<TextMeshProUGUI> ().text = "Lamentablemente no pudiste alcanzar los $10000 de saldo para poder comprar tu motocicleta.";
            reg2 = false;
        }
        if(reg1 && reg2){
            regla3.GetComponent<TextMeshProUGUI> ().text = "¡Excelente! Cumpliste ambas metas gracias a las buenas decisiones financieras que tomaste";
        }else{
            regla3.GetComponent<TextMeshProUGUI> ().text = "No pudiste cumplir ambas metas, pero no significa que hayas hecho un mal trabajo con tus decisiones financieras. ¡Siempre hay espacio para mejorar!";
        }
    }
}
