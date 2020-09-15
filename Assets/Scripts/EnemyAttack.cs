using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] int damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth player = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        player.LoseHealth(damage);
    }
}
