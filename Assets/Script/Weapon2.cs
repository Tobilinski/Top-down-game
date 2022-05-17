using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    public Transform Firepoint;

    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
    }
}
