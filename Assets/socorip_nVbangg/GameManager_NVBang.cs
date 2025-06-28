using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager_NVBang : MonoBehaviour
{
    public GameObject gameOverUI;

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
