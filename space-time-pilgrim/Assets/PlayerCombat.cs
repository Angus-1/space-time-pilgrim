using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange= 0.5f;
    public LayerMask enemyLayers;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Attack();
        }
        
    }

    void Attack()
    {
     animator.SetTrigger("Attack");

     Collider2D [] hitEnemies= Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
     
     foreach(Collider2D enemy in hitEnemies)
     {
      Debug.Log("hit " + enemy.name); 
     }

 
    }


    void DrawGizmosSelected()
    {
        if(attackPoint==null)
        Debug.Log("attack point null");
        return;

    
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        
    }
}
