using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOvement : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jump = 2f;

    Vector3 velocity;
    private bool isOnGround;
    [SerializeField] private Transform grounsCheck;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask layerMask;
    [SerializeField] private  float jumpForce = 2f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

   
    void Update()
    {
        isOnGround = Physics.CheckSphere(grounsCheck.position, groundCheckRadius, layerMask);
        if (isOnGround && velocity.y < 0) 
        {
            transform.Translate(0f, jump, 0f);
        }
        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }



        float x = Input.GetAxis("Horizontal"); 
        float z = Input.GetAxis("Vertical");  // 1, -1

        Vector3 move = transform.right * x + transform.forward * z; // new Vextor 3
        controller.Move(move * speed * Time.deltaTime);
        
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


    }
}
