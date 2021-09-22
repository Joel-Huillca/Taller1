using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAtaque : MonoBehaviour
{
    public PersonajeVida personajeVida;

    public float puntosEnemigo = 0.5f;
    
    public void ataqueJugador(){
        
        personajeVida.recibirAtaque (puntosEnemigo);
    }

    private void Update() {
        presionarBoton();
    }

    public void presionarBoton(){
        
        if (Input.GetKeyDown(KeyCode.T) ==true) {
            ataqueJugador();
        }
    }

}
