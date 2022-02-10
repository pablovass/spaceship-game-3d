using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ocurre el game over and destruye los elementos

public class DestroyOutOfBounds : MonoBehaviour
{
    
    
    private float topBound = 4.8f;
    private float LowerBound = -4.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > topBound)
        {
            Destroy(this.gameObject);
        }  
        if (this.transform.position.z < LowerBound)
        {
            Debug.Log("GAME OVER!!!!");
            Destroy(this.gameObject);
        }    
    }
}
