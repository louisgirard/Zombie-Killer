using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health = 5;

    bool dead = false;

    public bool isDead()
    {
        return dead;
    }

    public void LoseHealth(int damage)
    {
        BroadcastMessage("OnDamageTaken");
        health -= damage;
        if(health <= 0 && !isDead())
        {
            KillEnemy();
        }
    }

    private void KillEnemy()
    {
        dead = true;
        GetComponent<Animator>().SetTrigger("die");
    }
}
