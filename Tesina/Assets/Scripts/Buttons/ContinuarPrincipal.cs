using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuarPrincipal : MonoBehaviour
{
    public Canvas actual;
    public Canvas target;

    public void TaskOnClick(){
        Debug.Log("Esta es la escena");
        Debug.Log(Points.scene);
        if(Points.totalBudget < 0){
            Canvas cActual = actual.GetComponent<Canvas>();
            Canvas cTarget = target.GetComponent<Canvas>();
            Debug.Log ("You have clicked the button!");
            cTarget.enabled = true;
            cActual.enabled = false;
        }else{
            if (Points.scene == 2 || Points.scene == 6){
            SceneManager.LoadScene("Inst Parkour");
            }else if (Points.scene == 3 || Points.scene == 7){
                SceneManager.LoadScene("Inst Hurdle");
            }else if (Points.scene == 4 || Points.scene == 8){
                SceneManager.LoadScene("Inst Car");
            }else if (Points.scene == 5){
                SceneManager.LoadScene("Inst Laberinto");
            }else{
                SceneManager.LoadScene("Final");
            }
        }
        
    }
}
