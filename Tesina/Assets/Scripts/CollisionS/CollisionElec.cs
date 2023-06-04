using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionElec : MonoBehaviour
{
    public System.DateTime startTime;
    public int totalSeconds;
    // Start is called before the first frame update
    void Start()
    {
        startTime = System.DateTime.UtcNow;
    }

     void OnCollisionEnter(Collision collision)
    {
        //Get the time it took the user to complete the game
        System.TimeSpan ts = System.DateTime.UtcNow - startTime;
        totalSeconds = ts.Minutes * 60;
        totalSeconds = totalSeconds + ts.Seconds;
        //Reward Depending on time
        if(totalSeconds < 45){
            Points.bonus = 800;
        }else if (totalSeconds <65){
            Points.bonus = 500;
        }else{
            Points.bonus = 200;
        }
        //Set global variables values
        Points.time = totalSeconds;
        Points.totalBudget = Points.totalBudget + Points.bonus;
        //Change Scene
        Points.scene = Points.scene + 1;
        SceneManager.LoadScene("Finanzas");
    }
}
