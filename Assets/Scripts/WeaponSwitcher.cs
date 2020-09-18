using System;
using System.Net;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] Weapon[] weapons;

    int currentWeapon = 0;

    private void Start()
    {
        weapons[currentWeapon].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        int previousWeapon = currentWeapon;
        ProcessKeyInput();
        ProcessScrollWheel();

        if(previousWeapon != currentWeapon)
        {
            weapons[previousWeapon].gameObject.SetActive(false);
            weapons[currentWeapon].gameObject.SetActive(true);
        }
    }

    private void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }
    }

    private void ProcessScrollWheel()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            currentWeapon--;
            if (currentWeapon < 0)
            {
                currentWeapon = weapons.Length - 1;
            }
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            currentWeapon = (currentWeapon + 1) % weapons.Length;
        }
    }
}
