using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    [SerializeField] private float attackCoolDown;
    [SerializeField] private float range;
    [SerializeField] private int damage;
    [SerializeField] private float colliderDistance;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask playerLayer;
    private float cooldownTimer = Mathf.Infinity;

    private Health playerHealth;

    public Animator animator;


    private void Update() 
    {
        cooldownTimer += Time.deltaTime;


        if (PlayerInSight())
        {
           if (cooldownTimer >= attackCoolDown)
        {
            cooldownTimer = 0;

            DamagePlayer();

        } 
        
        }
        
    }

    private bool PlayerInSight()
    {
        RaycastHit2D hit =
         Physics2D.BoxCast(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance,
         new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y - 0.5f, boxCollider.bounds.size.z),
         0, Vector2.left, 0, playerLayer);

         if(hit.collider != null)
         {
             playerHealth = hit.transform.GetComponent<Health>();
         }

        return hit.collider != null;
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderDistance, 
        new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y - 0.5f, boxCollider.bounds.size.z));
    }

    private void DamagePlayer()
    {
        if(PlayerInSight())
        {
            Debug.Log("Player attacked");
            playerHealth.TakeDamage(damage);
        }
        else
        {
        }
    }
}
