using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //Range & Damage TBD
    public float attackRange = 0.5f;
    public float attackDamage = 0.2f;
    private Transform Player;
    

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        if (Player != null && Vector3.Distance(transform.position, Player.position) <= attackRange)
        {
            Attack();
            PushbackDamage();
        }
    }

    void Attack()
    {
        Player.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
    }

    public void PushbackDamage()
    {
        Player.GetComponent<Rigidbody2D>().linearVelocity *= 5;
    }
}
