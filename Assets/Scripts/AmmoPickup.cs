using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammount;
    [SerializeField] AmmoType ammoType;
    [SerializeField] AudioClip ammoSFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Ammo ammoSlot = other.GetComponent<Ammo>();
            ammoSlot.IncreaseAmmo(ammoType, ammount);
            AudioSource.PlayClipAtPoint(ammoSFX, transform.position);
            Destroy(gameObject);
        }
    }
}
