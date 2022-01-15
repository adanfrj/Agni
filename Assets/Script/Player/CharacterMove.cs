using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMove : MonoBehaviour
{
    public float dirX, speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float jumpCount = 0.0f;
    float maxJump = 1f;
    private Vector3 moveDirection;
    private Rigidbody rb;
    private Animator anim;
    private bool facingRight = true;
    public int currentHealth;

    public Transform groundCheck;
    public LayerMask groundLayer;
    
    private SpriteRenderer agniSR;

    public bool isGrounded;
    
    private CharacterSoundController sound;


    public void Awake()
    {
        this.agniSR = this.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
        sound = GetComponent<CharacterSoundController>();
        currentHealth = gameObject.GetComponent<PlayerStats>().currentHealth;
    }


    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        controller.Move(moveDirection * Time.deltaTime);

        //groundcheck
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.2f, groundLayer);

        // Apply gravity 
        moveDirection.y -= gravity * Time.deltaTime;

        if (!controller.isGrounded)
        {
            moveDirection.x = Input.GetAxis("Horizontal") * speed;
        }
        else
        {
            moveDirection.x = Input.GetAxis("Horizontal") * speed;
            jumpCount = 0.0f;
        }

        if (jumpCount < maxJump)
        {
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
                jumpCount++;
                sound.PlayJump();
            }
        }


        if (controller.collisionFlags == CollisionFlags.Sides)
        {
            jumpCount = 0.0f;
        }

        SetAnimationState();    

        this.agniSR.flipX = agniSR.transform.position.x < this.transform.position.x;
    }

    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "Ground")
        {
            jumpCount = maxJump;
            sound.Landing();
        }
    }

    void SetAnimationState()
    {
        //if Idle
        if (speed == 0)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
        }

        //if walking
        if (Input.GetKeyDown("d") || Input.GetKeyDown("a") || Input.GetKeyDown("right") || Input.GetKeyDown("left"))
        {
            anim.SetBool("isWalking", true);
        }

        //if not walking
        if (Input.GetKeyUp("d") || Input.GetKeyUp("a") || Input.GetKeyUp("right") || Input.GetKeyUp("left"))
        {
            anim.SetBool("isWalking", false);
        }

        //if jumping
        if(!isGrounded)
        {
            anim.SetBool("isJumping", true);
        }

        if (isGrounded)
        {
            anim.SetBool("isJumping", false);
        }
    }

    void CheckWhereToFace()
    {
        if (dirX > 0)
        {
            facingRight = true;
        }
        else if (dirX < 0)
        {
            facingRight = false;
        }
        if (((facingRight) && (moveDirection.x < 0)) || ((!facingRight) && (moveDirection.x > 0)))
            moveDirection.x *= -1;

        transform.localScale = moveDirection;
    }


}
