﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rbwind;
    private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
        //initiate wind
        rbwind = this.GetComponent<Rigidbody2D>();
        rbwind.velocity = new Vector2 (-speed,0);

        //Destroy wind when leave screen
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    //Update is called once per frame
    void Update()
    {
        //if(transform.position.x < screenBounds.x *2)
        //{
           // Destroy(this.gameObject);
        //}
    }
}