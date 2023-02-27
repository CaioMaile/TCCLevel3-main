using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public float rotationSpeed;
    private float ySpeed;
    public CharacterController controller;
    public float gravityScale;
    private Transform cameraTransform;
    public Animator anim;

    

    private Vector3 moveDirection;
    
    void Start()
    {
        
    }

    void Update()
    {



        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        moveDirection = (transform.forward * verticalInput) + (transform.right * horizontalInput);
        //moveDirection = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * moveDirection;
        moveDirection.Normalize();
        float magnitude = moveDirection.magnitude;
        magnitude = Mathf.Clamp01(magnitude);
        transform.Translate(moveDirection * magnitude * moveSpeed * Time.deltaTime, Space.World);

        ySpeed += Physics.gravity.y * Time.deltaTime;

        

        Vector3 velocity = moveDirection * magnitude;
        velocity.y = ySpeed;
        controller.Move(velocity * Time.deltaTime);
        if (controller.isGrounded)
        {
           ySpeed = -0.5f;
            if (Input.GetButtonDown("Jump"))
            {
                ySpeed = jumpForce;
            }
        }

       /*if (moveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
        
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        */

        //moveDirection.y = moveDirection.y + (Physics.gravity.y  * gravityScale * Time.deltaTime);
        
        controller.Move(moveDirection * Time.deltaTime * moveSpeed);

        //anim.SetBool("IsGrounded", controller.isGrounded);
        anim.SetFloat("Speed", (Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"))));
    }
}
