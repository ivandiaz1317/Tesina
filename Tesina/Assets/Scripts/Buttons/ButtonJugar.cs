using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonJugar : MonoBehaviour
{
    public void TaskOnClick(){
		    Debug.Log ("You have clicked the button!");
        SceneManager.LoadScene("Scene 2");
	  }
}
