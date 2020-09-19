using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammount;
    [SerializeField] AmmoType ammoType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Ammo ammoSlot = other.GetComponent<Ammo>();
            ammoSlot.IncreaseAmmo(ammoType, ammount);
            Destroy(gameObject);
        }
    }
}
