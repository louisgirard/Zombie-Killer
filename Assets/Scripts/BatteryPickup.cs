using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Flashlight flashlight = other.GetComponentInChildren<Flashlight>();
            flashlight.ChargeBattery();
            Destroy(gameObject);
        }        
    }
}
