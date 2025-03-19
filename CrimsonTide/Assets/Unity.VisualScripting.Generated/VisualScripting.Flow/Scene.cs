using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public GameObject player;
    public bool isPaused = false;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Game1() => SceneManager.LoadScene(2);

    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(2); 
    }
    public void pauseGame()
    {
        if (isPaused)
        {
            player.transform.localScale = Vector3.one;
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            player.transform.localScale = Vector3.zero;
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
