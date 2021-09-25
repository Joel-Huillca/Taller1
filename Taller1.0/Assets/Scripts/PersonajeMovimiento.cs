using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeMovimiento : MonoBehaviour
{
  bool canJump;
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left"))
        {
          gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-500f*Time.deltaTime, 0));
          gameObject.GetComponent<Animator>().SetBool("movimiento", true);
          

        }
      if(Input.GetKey("right")){
          gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500f*Time.deltaTime, 0));
          gameObject.GetComponent<Animator>().SetBool("movimiento", true);
          
      }
      if(!Input.GetKey("left") && !Input.GetKey("right")){
        gameObject.GetComponent<Animator>().SetBool("movimiento", false);
      }

      if(Input.GetKeyDown("up") && canJump){
        canJump = false;
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 240f));
      }
       }
        private void OnCollisionEnter2D(Collision2D collision) {
         if(collision.transform.tag == "ground"){
           canJump = true;
         }
       }
       
    }
