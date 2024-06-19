using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private CharacterController controller;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float sprintingMultiplier;
    [SerializeField] private Vector3 velocity;
    [SerializeField] private LayerMask floorLayer;

    [SerializeField] private Camera Camera;
    [SerializeField] private float mouseSensitivity;

  
   
  
  
    


    private const float gravityAcceleration = -9.81f;
    private Vector3 moveDirection;
    private Vector2 aimDirection;
    


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Camera.transform.localEulerAngles = transform.localEulerAngles;
        aimDirection.y = 0;
    }

   
    void Update()
    {
        MovePlayer();
        RotatePlayer();
        Jump();
        applyGravity();
        
      
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            velocity.y = jumpForce;
           
        }
    }


    void applyGravity()
    {
        if(!isGrounded())
        {
            velocity.y += gravityAcceleration * Time.deltaTime;
            if (velocity.y < -9f)
            {
                velocity.y = -9f;
            }
        }
        else if(velocity.y < 0)
        {
            velocity.y = 0;
        }
        

        controller.Move(velocity * Time.deltaTime);
    }

    bool isGrounded()
    {
        return Physics.CheckSphere(transform.position, 0.3f, floorLayer);
    }


    void MovePlayer()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.z = Input.GetAxisRaw("Vertical");

        float tempMulitplier = 1;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            tempMulitplier = sprintingMultiplier;

        }

        controller.Move(((transform.right * moveDirection.x) + (transform.forward * moveDirection.z)) * Time.deltaTime * speed * tempMulitplier);
    }


    void RotatePlayer()
    {
        aimDirection.x = Input.GetAxisRaw("Mouse X");
        aimDirection.y += -Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mouseSensitivity;



        aimDirection.y = Mathf.Clamp(aimDirection.y, -85f, 85f);

        Camera.transform.localEulerAngles = new Vector3(aimDirection.y, 0, 0);
        transform.Rotate(Vector3.up, aimDirection.x * Time.deltaTime * mouseSensitivity);
    }


  
}
