using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        SkullEnemy skullEnemy = hitInfo.GetComponent<SkullEnemy>();
        SlimeEnemy slimeEnemy = hitInfo.GetComponent<SlimeEnemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        else if (skullEnemy != null)
        {
            skullEnemy.TakeDamage(damage);
        }
        else if (slimeEnemy != null)
        {
            slimeEnemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
