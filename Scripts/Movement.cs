using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public CharacterController2D controller;
    float runSpeed = 40f;
    float horizontalMove = 0f;
    public bool jump = false;
    public bool crouch = false;
    public Animator animator;
    public BoxCollider2D bColider;
    public float health = 100f;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(this.gameObject);//aka die
        }
    }
    void Update() {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch")) { 
            crouch = true;
            animator.SetBool("isCrouching", true);
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
            animator.SetBool("isCrouching", false);
        }
    }

    void FixedUpdate() {
        controller.Move(horizontalMove*Time.fixedDeltaTime, crouch, jump);
        jump = false  ;
    }
}
