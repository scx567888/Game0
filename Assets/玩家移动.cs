using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 玩家移动 : MonoBehaviour
{
    public Rigidbody rb;

    public float fr=500;

    // Start is called before the first frame update
    void Start()
    {
        // rb.AddForce(0,100,2000);
        // rb.useGravity = false;
        // Debug.Log("123123123123");
    }

    // Update is called once per frame
    void Update()
    {
        // rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        // if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, fr * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -1*fr * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(10, 0,0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-10, 0,0);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, 20,0);
        }
    }
}