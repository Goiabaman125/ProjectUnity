using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour{

 private float timebtwAttack;
 public float starttimebtwAttack;
 public Transform attackPos;
 public LayerMask whatIsEnemies;
 public float attackRange;
 public int damage;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timebtwAttack <=0)
       if(Input.GetKey(KeyCode.Space)) 
       Collider2D[] enemiestodamage= Physics2D.OverlapCircleAll(attackPos.position,attackRange,whatIsEnemies);
       for (int i=o; i < enemiestodamage.Lenght;i++){
           enemiestodamage[i].GetComponent<Enemy>().TakeDamage(damage);
       }
    
    timebtwAttack = starttimebtwAttack;
    else
    {
        timebtwAttack -= Time.deltaTime;
    }

    }
    void OnDrawGizmosSelected(){
        Gizmos.color=Color.red;
        Gizmos.DrawWireSphere(attackPos.position,attackRange);
    }
}