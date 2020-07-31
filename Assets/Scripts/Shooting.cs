using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bullerForce = 1000;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Vector3 huongdan = new Vector3(firePoint.position.x,firePoint.position.y,firePoint.position.z);
        GameObject bullet = Instantiate(bulletPrefab,huongdan,firePoint.rotation);
        Rigidbody rbbullet = bullet.GetComponent<Rigidbody>();
        rbbullet.AddForce(-firePoint.forward * bullerForce,ForceMode.Impulse);
    }
}
