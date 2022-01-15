using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x <= -100f)
        {
            transform.localScale = new Vector3 (-1f, 1f, 1f);
        }
        else if (player.transform.position.x >= 100f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
