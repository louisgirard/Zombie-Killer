using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float range = 100f;

    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range);
        print(hit.transform.name);
    }
}
