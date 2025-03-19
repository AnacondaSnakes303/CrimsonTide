using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UpDownPlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    float verticalInput;
    public Collision2D collision;
    private Transform Player;
    public Button PauseButton;
    bool isPaused = false;
    public GameObject player;

    [SerializeField] 
    float speed;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * verticalInput * speed);

        
    }
    /*
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
*/

}
