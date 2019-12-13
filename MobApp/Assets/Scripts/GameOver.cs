using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsOver = false;
    public GameObject gameOverUI, restartButton;
    Player player;
    // Update is called once per frame
    void Start()
    {
        gameOverUI.SetActive(false);
        restartButton.SetActive(false);
    }
    public void gameOver()
    {
        if(player.curHealth <= 0)
        {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsOver = true;
        }
    }
    public void Restart()
    {
        Debug.Log("HCIWNCI");
        restartButton.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
