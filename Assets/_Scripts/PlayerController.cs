using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//como detecto el movimiento en horzontal 
// se nesesita el input y la velocidad.

public class PlayerController : MonoBehaviour
{
 
 public float horizontalInput;
 public  float verticalInput; 
 [SerializeField] private float speed = 10.0f;
 public float xRage =8.3f; // el rango disponible de la pantalla o limite   
 public float yRage =4.4f;
 // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //modifico el transform desde tralate para que se mueva [siempre son 4 cosas]
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);

        //limites horizontales
        if (transform.position.x<-xRage)
        {
            // se sale de la pantalla 
            transform.position = new Vector3(-xRage, transform.position.y, transform.position.z);
        }if (transform.position.x> xRage)
        {
            // se sale de la pantalla 
            transform.position = new Vector3(xRage, transform.position.y, transform.position.z);
        }
        
        //limites vertical 
        if (transform.position.y<-yRage)
        {
            // se sale de la pantalla 
            transform.position = new Vector3(transform.position.x, -yRage, transform.position.z);
        }if (transform.position.y> yRage)
        {
            // se sale de la pantalla 
            transform.position = new Vector3(transform.position.x, yRage, transform.position.z);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
