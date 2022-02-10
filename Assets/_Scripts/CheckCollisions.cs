using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
   [SerializeField] private GameObject explosion;
    //se llamara automaticamente cuando 
    //un objeto fisico entre dentro del trigger del game object
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);

        }
        
        Destroy(other.gameObject);
    }
}
