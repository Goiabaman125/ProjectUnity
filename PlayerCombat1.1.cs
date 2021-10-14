using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public int maxHealth = 100
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
       currentHealth = maxHealth 
    }

    public void TakeDamage(int damage)
    {
        currentHealth -=damage;
        //play hurt animation

        animator.SetTrigger("Hurt");

        if(currentHealth <=0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");

        //Die animation
        animator.SetBool("IsDead",true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
