using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
  
    public Animator animator;

    public Transform attackpoint;
    public float attackRange = 1f;
    public LayerMask enemyLayers;

    public int attackDamage = 20;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
            Attack();
            nextAttackTime = Time.time + 2f / attackRate;
            }
        }
        
    }
    void Attack() {

        // play attack animation
        animator.SetTrigger("Attack");

        
        //detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackpoint.position, attackRange, enemyLayers);

        // damage enemies
        foreach(Collider2D enemy in hitEnemies) 
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected() 
    {
        if (attackpoint == null)
            return;

        Gizmos.DrawWireSphere(attackpoint.position, attackRange);
    }

}
