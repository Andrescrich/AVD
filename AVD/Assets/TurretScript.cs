using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    [SerializeField] private Transform bulletPoint1;
    [SerializeField] private Transform bulletPoint2;
    [SerializeField] private Transform bulletPoint3;
    [SerializeField] private Transform bulletPoint4;
    [SerializeField] private GameObject bullet;


    public void Shooting()
    {
        StartCoroutine(ShootCor());
    }

    private IEnumerator ShootCor()
    {
        Shoot(bulletPoint1.transform);
        yield return new WaitForSeconds(0.2f);
        Shoot(bulletPoint2.transform);
        yield return new WaitForSeconds(0.2f);
        Shoot(bulletPoint3.transform);
        yield return new WaitForSeconds(0.2f);
        Shoot(bulletPoint4.transform);
        yield return new WaitForSeconds(0.2f);
    }

    private void Shoot(Transform point)
    {
        Instantiate(bullet, point.position, point.rotation);
    }
}
