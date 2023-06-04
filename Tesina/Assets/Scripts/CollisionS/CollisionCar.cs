using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionCar : MonoBehaviour
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
        System.TimeSpan ts = System.DateTime.UtcNow - startTime;
        totalSeconds = ts.Minutes * 60;
        totalSeconds = totalSeconds + ts.Seconds;
        Debug.Log (ts.ToString ());
        Debug.Log (totalSeconds);
        if(totalSeconds < 40){
            Points.bonus = 800;
        }else if (totalSeconds <60){
            Points.bonus = 500;
        }else{
            Points.bonus = 200;
        }
        Points.time = totalSeconds;
        Points.totalBudget = Points.totalBudget + Points.bonus ;
        Points.scene = Points.scene + 1;
        SceneManager.LoadScene("Finanzas");
    }
}
