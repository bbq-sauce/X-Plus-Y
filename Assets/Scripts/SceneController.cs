using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    
    public string mainMenuSceneName = "MainMenu";
    public string gameSceneName = "GameScreen";
    public string gameOverSceneName = "GameOverScreen";

    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene(gameOverSceneName);
    }
}

