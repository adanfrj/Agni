﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -12f, 58.78f), Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
    }
}
