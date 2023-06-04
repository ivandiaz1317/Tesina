using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionBakery : MonoBehaviour
{
    public System.DateTime startTime;
    public int totalSeconds;
    // Start is called before the first frame update
    void Start()
    {
        startTime = System.DateTime.UtcNow;
    }

    // Update is called once per frame
     void OnCollisionEnter(Collision collision)
    {
        System.TimeSpan ts = System.DateTime.UtcNow - startTime;
        totalSeconds = ts.Minutes * 60;
        totalSeconds = totalSeconds + ts.Seconds;
        Debug.Log (ts.ToString ());
        Debug.Log (totalSeconds);
        if(totalSeconds < 40){
            Points.bonus = 800;
        }else if (totalSeconds <50){
            Points.bonus = 500;
        }else{
            Points.bonus = 200;
        }
        Points.time = totalSeconds;
        Points.totalBudget = Points.totalBudget + Points.bonus ;
        Points.scene = Points.scene + 1;
        if (Points.scene > 4){
            SceneManager.LoadScene("Accidente");
        }else{
            SceneManager.LoadScene("Finanzas");
        }
    }
}
