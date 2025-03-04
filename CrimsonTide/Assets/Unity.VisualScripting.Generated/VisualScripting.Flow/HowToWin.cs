using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToWin : MonoBehaviour
{
    private GameObject TriggerObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}
