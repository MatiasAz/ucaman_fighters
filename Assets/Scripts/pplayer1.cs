using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// This script moves the character controller forward
// and sideways based on the arrow keys.
// It also jumps when pressing space.
// Make sure to attach a character controller to the same game object.
// It is recommended that you make only one call to Move or SimpleMove per frame.

public class pplayer1 : MovingEntity
{
    //CharacterController characterController;

    //public float speed = 6.0f;
    //public float jumpSpeed = 8.0f;
    //public float gravity = 20.0f;

    

    void Start()
    {
        //characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
         Vector3 moveDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right;
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.back;
        }

        if (moveDirection != Vector3.zero)
        {
            MoveTowards(moveDirection.normalized);
        }


















        /*if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
        */
    }
    public void OndeadHandler()
    {
        SceneManager.LoadScene("ucaman_scene");
    }
}