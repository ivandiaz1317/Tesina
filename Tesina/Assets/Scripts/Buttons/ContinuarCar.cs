using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuarCar : MonoBehaviour
{
    // Start is called before the first frame update
    public void TaskOnClick(){
        if (Points.scene == 4){
            SceneManager.LoadScene("CarDriver");
        }else{
            SceneManager.LoadScene("CarDriver 2");
        }
        
	}
}
