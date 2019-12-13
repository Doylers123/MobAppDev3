using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        SoundManager.PlaySound("Coin");
        Score.scoreAmount +=1;
        Destroy(gameObject);
    }
}
