using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeEnemy : MonoBehaviour
{
    public int health;
    public int damaged;
    public GameObject damageEffect;
 

    

    public void TakeDamage(int damage) 
    {

        health -= damage;
        SoundManager.PlaySound("Slime");
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
         
         if(gameObject.tag == "Boss")
         {
             SceneManager.LoadScene(4);
         }
     }

        

        void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.tag == "Player")
            {
                col.gameObject.GetComponent<Player>().Damage(damaged);
            }
        
    }
}

