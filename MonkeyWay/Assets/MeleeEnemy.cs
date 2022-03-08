using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    [SerializeField] private float attackCoolDown;
    [SerializeField] private float range;
    [SerializeField] private int damage;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask playerLayer;
    private float cooldownTimer = Mathf.Infinity;

    private void Update() 
    {
        cooldownTimer += Time.deltaTime;


        if (PlayerInSight())
        {
           if (cooldownTimer >= attackCoolDown)
        {
            //attack
        } 
        
        }
        
    }

    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center + transform.right * range ,boxCollider.bounds.size,
         0, Vector2.left, 0, playerLayer);

        return hit.collider != null;
    }


}
