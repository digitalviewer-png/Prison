using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Animator animator;

    [SerializeField] private LayerMask groundMask;


    [SerializeField] private Transform groundCheck;
    
    [SerializeField] private float speed = 6f;
    [SerializeField] private float run = 12f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private float jumpHeight = 3f;


    private Vector3 playerVelocity;

    private bool isGrounded;

    public void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && playerVelocity.y < 0) 
        {
            playerVelocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * x + transform.forward * z;
        characterController.Move(move * speed * Time.deltaTime);

        animator.SetFloat("Forward", z);
        animator.SetFloat("Strafe", x);
        

        if (Input.GetButtonDown("Jump") && isGrounded) 
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            animator.SetTrigger("isJumping");
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            characterController.Move(move * run * Time.deltaTime);
        }
 

        playerVelocity.y += gravity * Time.deltaTime;

        characterController.Move(playerVelocity * Time.deltaTime); 
    }
}
