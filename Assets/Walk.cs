using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public CharacterController CC;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpForce = 3f;
    public float checkRadius = 3f;

    public Transform groundCheck;

    public LayerMask whatIsGround;

    bool isGrounded;

    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, whatIsGround);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        float X = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * X + transform.forward*z;

        CC.Move(move * speed *Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpForce *gravity* -2f);
        }

        velocity.y +=gravity*Time.deltaTime;

        CC.Move(velocity * Time.deltaTime);
    }
}
