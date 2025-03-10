using UnityEngine;
using System.Collections;


public class UpDownPlayerMovement : MonoBehaviour
{
    private float horizontalInput;
    float verticalInput;
    public Collision2D collision;
    private Transform Player;

    [SerializeField] 
    float speed;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * verticalInput * speed);
    }
    
}
