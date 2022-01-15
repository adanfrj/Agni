using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    private Transform target; //the enemy's target

    public float moveSpeed; //move speed
    public float distances;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) >= distances)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }

        if (transform.position.y < target.position.y)
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        }
        else
        {
            transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
        } 
    }
}
