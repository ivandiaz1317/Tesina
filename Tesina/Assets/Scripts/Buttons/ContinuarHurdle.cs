using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuarHurdle : MonoBehaviour
{
    // Start is called before the first frame update
    public void TaskOnClick(){
        if (Points.scene == 3){
            SceneManager.LoadScene("Hurdle");
        }else{
            SceneManager.LoadScene("Hurdle 2");
        }
        
	}
}
