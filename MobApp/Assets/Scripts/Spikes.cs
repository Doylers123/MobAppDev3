using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public int damaged = 1;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.tag == "Player")
            {
                col.gameObject.GetComponent<Player>().Damage(damaged);
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
