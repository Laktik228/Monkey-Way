using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    private Transform target;
    private bool facingRight;
    public Animator animator;



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();       
    }

    void Update()
    {
        FacePlayer();
        var targetPos = new Vector2(target.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        animator.SetFloat("Speed", speed);

    }

    private async void FacePlayer()
    {
        if (facingRight == true)
        {
            if (target.position.x > transform.position.x)
            {
                
                facingRight = false;
                await Task.Delay(1500);
                Flip();
            }
        }
        else
        {
            if (target.position.x < transform.position.x)
            {
                facingRight = true;
                await Task.Delay(1500);
                Flip();
            }
        }
    }

    private void Flip()
	{
	

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

    
}
