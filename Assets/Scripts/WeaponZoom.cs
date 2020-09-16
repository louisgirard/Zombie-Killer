using UnityEngine;
using UnityEngine.Playables;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedInView = 30f;
    [SerializeField] float zoomedOutView = 60f;

    //test
    [SerializeField] Weapon weapon;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            weapon.Zoom(true);
            fpsCamera.fieldOfView = zoomedInView;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            weapon.Zoom(false);
            fpsCamera.fieldOfView = zoomedOutView;
        }
    }
}
