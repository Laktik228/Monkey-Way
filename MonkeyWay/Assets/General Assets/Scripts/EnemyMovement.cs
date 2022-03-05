using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool Attack = false;
    
    void Start()
    {
        
    }

    void Update()
    {

       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

       /* if (enemy is attacking) {
            Attack = true;
            animator.SetBool("IsAttacking", true);

        }
        
    }

    public void OnLanding( ) {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate () {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    */
}

}