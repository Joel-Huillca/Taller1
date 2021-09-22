using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAparecer : MonoBehaviour
{

    public GameObject enemigoPrefab;

      private void Awake() { //Al inicio del Juego aparecera el Enemigo (1:14 min Video)
        //aparecerEnemigo();    //aparece un enemigo
    }

     


    public void aparecerEnemigo(){
        //         ( Prefab - Posicion Enemigo - x )
        Instantiate(enemigoPrefab, this.transform.position, this.transform.rotation );

    }



}
