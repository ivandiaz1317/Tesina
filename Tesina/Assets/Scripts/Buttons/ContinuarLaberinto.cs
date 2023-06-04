using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuarLaberinto : MonoBehaviour
{
    // Start is called before the first frame update
    public void TaskOnClick(){
        if (Points.scene == 1){
            SceneManager.LoadScene("Laberinto");
        }else{
            SceneManager.LoadScene("Laberinto 2");
        }
        
	}
}
