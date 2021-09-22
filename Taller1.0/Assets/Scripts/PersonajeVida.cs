using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeVida : MonoBehaviour
{

    public float puntosVida =3.0f;


    public void recibirAtaque(float puntosEnemigo){
        puntosVida = puntosVida - puntosEnemigo;
    }

}
