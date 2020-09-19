using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health = 5;

    public bool isDead()
    {
        return (health <= 0);
    }

    public void LoseHealth(int damage)
    {
        BroadcastMessage("OnDamageTaken");
        health -= damage;
        if(health <= 0)
        {
            KillEnemy();
        }
    }

    private void KillEnemy()
    {
        GetComponent<Animator>().SetTrigger("die");
    }
}
