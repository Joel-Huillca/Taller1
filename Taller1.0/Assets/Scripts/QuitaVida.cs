using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitaVida : MonoBehaviour
{
      public PersonajeVida personajeVida;

    public float puntosEnemigo = 0.5f;
    
    public void ataqueJugador(){
        
        personajeVida.recibirAtaque (puntosEnemigo);
    }

    private void Update() {
        presionarBoton();
        

    }

    /**private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.compareTag("Player")){
            ataqueJugador();
        }
    }*/
    

    public void presionarBoton(){
        //Tocarlo 
        if (Input.GetKeyDown(KeyCode.T) ==true) {
            ataqueJugador();
        }
    }

}
