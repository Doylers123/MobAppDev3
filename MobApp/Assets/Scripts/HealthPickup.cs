using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class HealthPickup : MonoBehaviour
    {
        Player player;
        public int healthPickup = 1;

        void Awake()
        {
            player = FindObjectOfType<Player>();
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            if(player.curHealth < player.maxHealth)
        {
            SoundManager.PlaySound("Health");
            Destroy(gameObject);
            player.health = player.curHealth + healthPickup;
        }
    }
}
