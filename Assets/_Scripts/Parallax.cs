using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//hace que el backgroun tenga vida
public class Parallax : MonoBehaviour
{
    public float speed=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset=new Vector2(0f,(Time.time*speed)%1);
    }
}
