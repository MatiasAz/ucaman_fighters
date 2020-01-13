using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    public float flytime = 3f;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed, ForceMode.VelocityChange);
        Invoke("DestroyBullet", flytime);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
