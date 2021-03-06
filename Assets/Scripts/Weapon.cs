﻿using System;
using System.Collections;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float range = 100f;
    [SerializeField] int damage = 1;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] ParticleSystem hitEffect;
    [SerializeField] Ammo ammoSlot;
    [SerializeField] AmmoType ammoType;
    [SerializeField] float timeBetweenShots = .2f;
    [SerializeField] AudioClip shotSFX;

    Vector3 zoomedOutPosition;
    Quaternion zoomedOutRotation;

    [Header("Zoomed In Transform")]
    [SerializeField] Vector3 zoomedInPosition;
    [SerializeField] Vector3 zoomedInRotation;

    bool canShoot = true;

    private void OnEnable()
    {
        canShoot = true;
    }

    private void Start()
    {
        zoomedOutPosition = transform.localPosition;
        zoomedOutRotation = transform.localRotation;
    }

    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1") && canShoot)
        {
            if(ammoSlot.GetAmmo(ammoType) > 0)
            {
                StartCoroutine(Shoot());
            }
        }
    }

    IEnumerator Shoot()
    {
        canShoot = false;

        PlayMuzzleFlash();
        ProcessRaycast();
        AudioSource.PlayClipAtPoint(shotSFX, transform.position);
        ammoSlot.DecreaseAmmo(ammoType);
        yield return new WaitForSeconds(timeBetweenShots);

        canShoot = true;
    }

    private void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    private void ProcessRaycast()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            HitImpact(hit);
            EnemyHealth enemy = hit.transform.GetComponent<EnemyHealth>();
            if (enemy)
            {
                enemy.LoseHealth(damage);
            }
        }
    }

    private void HitImpact(RaycastHit hit)
    {
        ParticleSystem impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact.gameObject, hitEffect.main.duration);
    }

    public void Zoom(bool zoomIn)
    {
        if (zoomIn)
        {
            transform.localPosition = zoomedInPosition;
            transform.localRotation = Quaternion.Euler(zoomedInRotation);
        }
        else
        {
            transform.localPosition = zoomedOutPosition;
            transform.localRotation = zoomedOutRotation;
        }
    }
}
