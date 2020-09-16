using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    int ammoAmount = 10;

    public int GetAmmo()
    {
        return ammoAmount;
    }

    public void DecreaseAmmo()
    {
        ammoAmount--;
    }
}
