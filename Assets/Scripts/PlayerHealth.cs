using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health = 50;

    public void LoseHealth(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            print("player dead");
        }
    }
}
