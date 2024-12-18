using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public CharacterController characterController;
    public AudioSource footstepsSound;
    public float speed = 2f;
    private float Gravity = 9.8f;
    private float velocity = 0;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        * joystick left input axis or arrow keyboard input
        */
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //Debug.Log(x);
        //Debug.Log(y);

        Vector3 move = transform.right * x + transform.forward * y;
        controller.Move(move * speed * Time.deltaTime);

        if (characterController.isGrounded)
        {
            velocity = 0;
            velocity -= Gravity * Time.deltaTime;
        }
        else
        {
            characterController.Move(new Vector3(0, velocity, 0));
        }
        if (x != 0 || y != 0)
        {
            footstepsSound.enabled = true;
        }
        else
        {
            footstepsSound.enabled = false;
        }
    }
}
