using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverSceen : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void Setup()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
