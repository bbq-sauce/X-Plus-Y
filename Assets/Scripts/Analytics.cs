using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Analytics : MonoBehaviour
{
  public static Analytics instance;

    private void Start()
    {
        instance = this;
        Scene currentScene = SceneManager.GetActiveScene();

        if(currentScene.buildIndex == 0)
        {
            PlayerViewedMainMenu();
        }
        else if(currentScene.buildIndex == 1)
        {
            GameStarted();
        }
        else if (currentScene.buildIndex == 2)
        {
            GameOver();
        }
    }
    public void PlayerViewedMainMenu()
    {
        Debug.Log("Player Viewed Main Menu");
    }

    public void GameStarted()
    {
        Debug.Log("Player Started Game");
    }

    public void NumberPairs(int a, int b)
    {
        a= GameManager.instance.a; b= GameManager.instance.b;

        Debug.Log("NumberParSelected: ("+a+", "+b+")");
    }

    public void GameOver()
    {
        int score = GameManager.instance.score;
        Debug.Log("GameOver-> Score: " + score);
    }
}
