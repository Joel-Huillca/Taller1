using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMoneda : MonoBehaviour
{
    
    public static ContadorMoneda contadorMoneda;
    int score = 0;
    void Start()
    {
        contadorMoneda = this;
    }

    // Update is called once per frame
 public void RaiseScore(int s){
     score += s;
     Debug.Log(score);
 }
}
