using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform Firepoint;

    public GameObject bulletPrefab;
    public ParticleSystem trail;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Shoot();
            CreateTrail();
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
    }

    void CreateTrail()
    {
        trail.Play();
    }
}
