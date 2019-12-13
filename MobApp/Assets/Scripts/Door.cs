using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    Key key;
    public GameObject text;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(Key.keyGot == true)
        {
            SceneManager.LoadScene(3);
        }
        else if (col.tag == "Player")
        {
            text.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        text.SetActive(false);
    }
}
