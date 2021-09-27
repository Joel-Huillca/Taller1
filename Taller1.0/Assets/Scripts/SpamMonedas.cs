using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamMonedas : MonoBehaviour
{
    
    float timer;
    public GameObject coinPrefab;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 8f){
            timer = 0;
            float x = Random.Range(-8f, 6.63f);
            Vector3 position = new Vector3(x, 0, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab, position, rotation);
        }
        
    }
}
