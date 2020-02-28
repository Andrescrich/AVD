using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBulletScript : MonoBehaviour
{

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.AddForce(transform.up * 20f, ForceMode.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //StartCoroutine(StopTimeImpact());
            other.gameObject.GetComponent<FrogScript>().Death();
            Destroy(gameObject);
        }
    }
}
