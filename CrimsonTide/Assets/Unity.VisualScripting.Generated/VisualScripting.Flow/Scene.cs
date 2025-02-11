using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Game1() => SceneManager.LoadScene("Lowther Scene");

    public void StartScene()
    {
        SceneManager.LoadScene("Olivia - StartScene");
    }
}
