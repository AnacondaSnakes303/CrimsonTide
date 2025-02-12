using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // speed TBD
    public float speed = 1.0f;
    private Transform Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Player != null)
        {
            Vector3 direction = (Player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
