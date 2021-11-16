using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //player
    private Rigidbody2D rbchar;
    public bool isGrounded;
    float inputX;
    float inputY;

    private void Start()
    {
        rbchar = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Input Key
        inputX = Input.GetAxisRaw("Horizontal");

        //velocity
        rbchar.velocity = new Vector2(inputX * 5f, rbchar.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            if (isGrounded == true)
            {
                rbchar.velocity = new Vector2(rbchar.velocity.x, 8f);
                isGrounded = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
     {
         if (coll.gameObject.tag == "Ground")
         {
             isGrounded = true;
         }
     }
}
