using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
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
}
