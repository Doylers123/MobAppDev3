using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public int damaged;
    public GameObject damageEffect;
 

    

    public void TakeDamage(int damage) 
    {

        health -= damage;
        SoundManager.PlaySound("Bat");
        Instantiate(damageEffect, transform.position, Quaternion.identity);
    if(health <= 0)
         {
             Die();
         }
     }

     void Die() 
     {
        Instantiate(damageEffect, transform.position, Quaternion.identity);
         Destroy(gameObject);
     }

        

        void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.tag == "Player")
            {
                col.gameObject.GetComponent<Player>().Damage(damaged);
            }
        
    }
}

