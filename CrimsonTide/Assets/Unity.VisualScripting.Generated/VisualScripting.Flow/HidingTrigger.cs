using UnityEngine;

public class HidingTrigger : MonoBehaviour
{
    private SpriteRenderer DisappearingObject;
    public bool PlayerTag = false;

    void Start()
    {
        DisappearingObject = GetComponent<SpriteRenderer>();    
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        { 
           DisappearingObject.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            DisappearingObject.enabled=true;
        }
    }

}
