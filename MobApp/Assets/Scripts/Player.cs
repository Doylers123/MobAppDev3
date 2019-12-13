using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health;
    public int curHealth;
    public int numOfHearts;
    public int maxHealth;

    public int damaged;
    GameObject enemy;
    public GameObject damageEffect, gameOverText, restartButton;
    
    Score score;
    bool isDead;
    bool playerInRange;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    GameOver gameOver;
    

    void Start()
    {
        curHealth = 3;
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }
    void Update(){

       // scoreText.text = "Score: " + scoreAmount;
        maxHealth = numOfHearts;
        curHealth = health;

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

    public void Damage(int damaged){
        
        health -= damaged;
        Instantiate(damageEffect, transform.position, Quaternion.identity);
        SoundManager.PlaySound("hit");
        curHealth = health;
        Debug.Log("Damage");
        if(health <= 0){
            curHealth = health;
            Death();
        }
    }
    
    public void Death()
    {
        health -= damaged;
        numOfHearts = 0;
        Debug.Log("Dead");
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Coin"))
        {
            Score.scoreAmount += 1;
        }

        if(curHealth <= 0)
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            Time.timeScale = 0f;
            //gameOver.Restart();
        }
    }

    

   

}
