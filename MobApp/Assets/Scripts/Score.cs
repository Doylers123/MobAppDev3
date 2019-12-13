using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreAmount;
    public static int curScore;
    public Text scoreText;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
        //curScore = scoreAmount;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreAmount;
        //scoreAmount = curScore;
    }


}
