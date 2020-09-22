using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    PlayerHealth playerHealth;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = playerHealth.GetHealth().ToString();
    }
}
