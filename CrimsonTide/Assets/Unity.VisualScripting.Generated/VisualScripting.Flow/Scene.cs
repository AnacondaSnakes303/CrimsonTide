using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Game1()
    {
        SceneManager.LoadScene("KirraLockhartScene1");
    }

    public void StartScene()
    {
        SceneManager.LoadScene("Olivia - StartScene");
    }
}
