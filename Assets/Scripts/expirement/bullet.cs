using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float timeDestroy = 3f;
    public float speed = 10f;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Vector3 vector;
    private GameObject test;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
       // if () {Destroy() }
    }

    void Shoot()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.up * speed, ForceMode.Impulse);
        if (timeDestroy ==3f) {
            Destroy(bulletPrefab.gameObject);
                }
    }
}
