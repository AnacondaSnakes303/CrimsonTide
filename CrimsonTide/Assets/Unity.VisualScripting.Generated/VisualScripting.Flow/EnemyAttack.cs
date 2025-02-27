using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //Range & Damage TBD
    public float attackRange = 0.5f;
    public int attackDamage = 1;
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
        }
    }

    void Attack()
    {
        Player.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
    }
}
