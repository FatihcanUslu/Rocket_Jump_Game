using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed=10;
    public AudioSource rocketLauncher;
    void Update()
    {
        float shoot = Input.GetAxis("Fire1");
        //Debug.Log("girdi"+shoot);
        if (Input.GetMouseButtonDown(0))
        {
            rocketLauncher.Play();
            var bullet=Instantiate(bulletPrefab,bulletSpawnPoint.position,bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity=bulletSpawnPoint.right*bulletSpeed;

        }
    }
}
