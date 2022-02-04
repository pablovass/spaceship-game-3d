using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float xMin, xMax, zMin, zMax;
    public GameObject shot;
    public Transform shotContent;
    public float fireRate;
    public float nextFire;
    

    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time>nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot,shotContent.position,shotContent.rotation);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(horizontal, 5f, vertical);
        _rigidbody.velocity = vector * 10;

        _rigidbody.position = new Vector3(Mathf.Clamp(_rigidbody.position.x, xMin, xMax), 6.0f,
            Mathf.Clamp(_rigidbody.position.z, zMin, zMax));
        _rigidbody.rotation=Quaternion.Euler(0.0f,0.0f,_rigidbody.velocity.x*-2);
    }
}
