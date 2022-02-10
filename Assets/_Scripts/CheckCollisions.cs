using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    //se llamara automaticamente cuando 
    //un objeto fisico entre dentro del trigger del game object
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        Destroy(other.gameObject);
    }
}
