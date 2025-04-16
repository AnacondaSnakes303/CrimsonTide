using UnityEngine;

public class Testprecursor : MonoBehaviour
{
    bool isStarted = true;

    public void preGame()
    {
        if (isStarted)
        {
            Time.timeScale = 1;
            isStarted = true;
        }
        else
        {
            Time.timeScale = 0;
            isStarted = false;
        }
    }

    public void Start()
    {
        Time.timeScale = 0;
    }
}
