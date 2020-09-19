using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] AmmoSlot[] ammoSlots;

    [System.Serializable]
    private class AmmoSlot
    {
        public int ammoAmmount;
        public AmmoType ammoType;
    }

    public int GetAmmo(AmmoType ammoType)
    {
        AmmoSlot ammoSlot = GetAmmoSlot(ammoType);
        if (ammoSlot != null)
        {
            return ammoSlot.ammoAmmount;
        }
        else
        {
            return 0;
        }
    }

    public void IncreaseAmmo(AmmoType ammoType, int ammount)
    {
        AmmoSlot ammoSlot = GetAmmoSlot(ammoType);
        if (ammoSlot != null)
        {
            ammoSlot.ammoAmmount += ammount;
        }
    }

    public void DecreaseAmmo(AmmoType ammoType)
    {
        AmmoSlot ammoSlot = GetAmmoSlot(ammoType);
        if (ammoSlot != null)
        {
            ammoSlot.ammoAmmount--;
        }
    }

    private AmmoSlot GetAmmoSlot(AmmoType ammoType)
    {
        foreach (AmmoSlot ammoSlot in ammoSlots)
        {
            if (ammoSlot.ammoType == ammoType)
            {
                return ammoSlot;
            }
        }
        return null;
    }
}
