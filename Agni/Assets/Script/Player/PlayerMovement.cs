using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //player
    private Rigidbody2D rbchar;
    public Transform frontCheck;
    public LayerMask whatIsGround;
    public bool isGrounded;
    bool isTouchingFront;
    bool wallSliding;
    bool wallJumping;
    public float wallSlidingSpeed;
    public float checkRadius;
    public float xWallForce;
    public float yWallForce;
    public float wallJumpTime;
    float inputX;
    float inputY;

    //Collision
    public Collision2D enemy;
    public Collision2D ground;

    private void Start()
    {
        rbchar = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Input Key
        inputX = Input.GetAxis("Horizontal");

        //velocity
        rbchar.velocity = new Vector2(inputX * 10f, rbchar.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            if (isGrounded == true)
            {
                rbchar.velocity = new Vector2(rbchar.velocity.x, 8f);
                isGrounded = false;
            }
        }

        if(Input.GetKeyDown(KeyCode.W) && wallSliding == true)
        {
            wallJumping = true;
            Invoke("SetWallJumpingToFalse", wallJumpTime);
        }

        if (wallJumping == true)
        {
            rbchar.velocity = new Vector2(xWallForce * -inputX, yWallForce);
        }

        isTouchingFront = Physics2D.OverlapCircle(frontCheck.position, checkRadius, whatIsGround);

        if(isTouchingFront == true && isGrounded == false && inputX != 0)
        {
            wallSliding = true;
        }
        else
        {
            wallSliding = false;
        }

        if (wallSliding)
        {
            rbchar.velocity = new Vector2(rbchar.velocity.x, Mathf.Clamp(rbchar.velocity.y, -wallSlidingSpeed, float.MaxValue));
        }
    }

    private void OnCollisionEnter2D(Collision2D ground)
    {
         if (ground.gameObject.tag == "Ground")
         {
             isGrounded = true;
         }
    }

    void SetWallJumpingToFalse()
    {
        wallJumping = false;
    }
    
}
