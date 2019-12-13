using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGraphic : MonoBehaviour
{
    public AIPath aiPath;
    private Material matWhite;
    private Material matDefault;
    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = sr.material;
    }
    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)//if positive, travelling right
        {
            transform.localScale = new Vector3(-0.25f, 0.25f, 0.25f);
        } else if (aiPath.desiredVelocity.x <= -0.01f)//if negative, travelling left
        {
            transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bullet"))
        {
            sr.material = matWhite;
        }
    }
}
