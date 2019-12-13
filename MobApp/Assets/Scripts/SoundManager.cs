using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip hit, bat, health, gun, coin, slime, skull, key;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        hit = Resources.Load<AudioClip> ("hit");
        bat = Resources.Load<AudioClip> ("Bat");
        health = Resources.Load<AudioClip> ("Health");
        gun = Resources.Load<AudioClip> ("Gun");
        coin = Resources.Load<AudioClip> ("Coin");
        skull = Resources.Load<AudioClip> ("Skull");
        slime = Resources.Load<AudioClip> ("Slime");
        key = Resources.Load<AudioClip> ("Keys");
        


        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "hit":
            audioSource.PlayOneShot (hit);
            break;
            case "Bat":
            audioSource.PlayOneShot (bat);
            break;
            case "Health":
            audioSource.PlayOneShot (health);
            break;
            case "Gun":
            audioSource.PlayOneShot (gun);
            break;
            case "Coin":
            audioSource.PlayOneShot (coin);
            break;
            case "Skull":
            audioSource.PlayOneShot (skull);
            break;
            case "Slime":
            audioSource.PlayOneShot (slime);
            break;
            case "Keys":
            audioSource.PlayOneShot(key);
            break;


        }   
    }
}
