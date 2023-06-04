using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuarParkour : MonoBehaviour
{
    public void TaskOnClick(){
        if (Points.scene == 2){
            SceneManager.LoadScene("Parkour");
        }else{
            SceneManager.LoadScene("Parkour 2");
        }
        
	}
}
