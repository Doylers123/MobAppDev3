using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    int damageAmount;
    GameObject enemy;
    bool damaged;
    bool isDead;
    bool playerInRange;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    void Update(){
        for(int i = 0; i < hearts.Length; i++){

            if(health > numOfHearts){
                health = numOfHearts;
            }

            if(i < health){
                hearts[i].sprite = fullHeart;
            }
            else{
                hearts[i].sprite = emptyHeart;
            }

            
            if(i < numOfHearts){
                hearts[i].enabled = true;
            }
            else{
                hearts[i].enabled = false;
            }
        
        }
    }

     
/*
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == enemy)
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject == enemy)
        {
            playerInRange = false;
        }
    }*/

    public void Damage(){
        damaged = true;
        health -= 1;
        if (health < numOfHearts)
         {
             numOfHearts = health;
         }
        Debug.Log("Damage");

        

       // if(health <= 0 && isDead){
        //    Death();
       // }
    }

   /* public void Heal(int healAmount){
        health += healAmount;
    }

    public void Death(){
        isDead = true;
    }*/
}

