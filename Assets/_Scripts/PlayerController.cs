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
 public float zRage =4.4f;

 [SerializeField] private GameObject projectilePrefab;
 public float nextFire = 2;
 public float fireRate = 2;
 
 // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //movimiento del personaje
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
        if (transform.position.z<-zRage)
        {
            // se sale de la pantalla 
            transform.position = new Vector3(transform.position.x, transform.position.y,-zRage);
        }if (transform.position.z> zRage)
        {
            // se sale de la pantalla 
            transform.position = new Vector3(transform.position.x, transform.position.y,zRage );
        }
        
        //acciones del personaje
        //if (Input.GetKey(KeyCode.Space))
        //{
            //si entramos aqui ,hay que lanzar un proyectile
            //crear es instanciar
            // para instacioar hay que poner 3 cosas (que objeto instaciar?, en que posicion se va encontrar , y su rotacion : que en mi caso voy a usar la rotacion del objeto )
         //   Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
       // }
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
