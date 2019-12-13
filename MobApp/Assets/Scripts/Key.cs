using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
   public static bool keyGot = false;

   void OnTriggerEnter2D(Collider2D col)
   {
       keyGot = true;
       SoundManager.PlaySound("Keys");
       Destroy(gameObject);
   }
}
