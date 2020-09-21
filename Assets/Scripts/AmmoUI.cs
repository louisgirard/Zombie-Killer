using UnityEngine;
using UnityEngine.UI;

public class AmmoUI : MonoBehaviour
{
    [SerializeField] AmmoType ammoType;
    [SerializeField] Ammo ammoSlot;

    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ammoSlot.GetAmmo(ammoType).ToString();
    }
}
