using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedInView = 30f;
    [SerializeField] float zoomedOutView = 60f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 0.5f;
    RigidbodyFirstPersonController fpsController;

    //test
    [SerializeField] Weapon weapon;

    private void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            weapon.Zoom(true);
            fpsCamera.fieldOfView = zoomedInView;
            fpsController.mouseLook.XSensitivity = zoomInSensitivity;
            fpsController.mouseLook.YSensitivity = zoomInSensitivity;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            weapon.Zoom(false);
            fpsCamera.fieldOfView = zoomedOutView;
            fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
            fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
        }
    }
}
