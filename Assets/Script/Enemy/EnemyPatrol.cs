using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody rb;
    public LayerMask groundLayers;
    public Transform groundCheck;
    bool isFacingRight = true;


    // Start is called before the first frame update
    void Update()
    {
        //groundcheck
        bool isGrounded = Physics.CheckSphere(groundCheck.position, 3f, groundLayers);
    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Ground")
        {
            Debug.Log("Hit");
        }
    }

   
}
