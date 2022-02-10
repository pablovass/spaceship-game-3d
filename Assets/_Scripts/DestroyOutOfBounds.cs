using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Destroy(this.gameObject);
        }    
    }
}
