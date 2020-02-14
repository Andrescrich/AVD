using System;
using UnityEngine;

public class Player2DControl : MonoBehaviour
{
    public float speed = 20f;
    private float horizontalMove;
    private bool jump;
    private bool crouch;
    private CharacterController2D controller;
    private Animator anim;

    private void Awake()
    {
        controller = GetComponent<CharacterController2D>();
        anim = GetComponent<Animator>();
    }
    
    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        anim.SetFloat("Speed", Math.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            anim.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
            crouch = true;
        if (Input.GetButtonUp("Crouch"))
            crouch = false;
    }

    public void OnLanding()
    {
        anim.SetBool("IsJumping", false);
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
