using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] float lightDecay = .1f;
    float maxIntensity = 10f;
    Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        maxIntensity = light.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = light.intensity - lightDecay * Time.deltaTime;
    }

    public void ChargeBattery()
    {
        light.intensity = maxIntensity;
    }
}
