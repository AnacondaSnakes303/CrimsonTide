using UnityEngine;
using System.Collections;

public class UpDownPlayerMovement : MonoBehaviour
{
    public float speed;
    public Collision2D collision;
    private Transform Player;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector2.up * speed);
        }
    }
    
}
