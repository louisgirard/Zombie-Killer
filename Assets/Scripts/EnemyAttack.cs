using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] int damage = 5;
    PlayerHealth player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        player.LoseHealth(damage);
    }
}
