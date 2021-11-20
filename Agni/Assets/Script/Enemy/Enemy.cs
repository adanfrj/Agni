using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : SpawnEnemy
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CubeSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
