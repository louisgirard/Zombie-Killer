using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health = 5;
    
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
        Destroy(gameObject);
    }
}
