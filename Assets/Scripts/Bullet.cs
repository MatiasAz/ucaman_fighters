using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    public float flytime = 3f;
    public float damage = 10f;
    public float damage2 = 2f;
    float inicio = 0f;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed, ForceMode.VelocityChange);
        Invoke("DestroyBullet", flytime);
        inicio = Time.time;
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if((Time.time - inicio) >= 0.2f)
        {
            if (other.CompareTag("Ghost"))
            {
                other.SendMessage("DamageTaken", damage);
                DestroyBullet();
            }
            else if (other.CompareTag("wall"))
            {
                DestroyBullet();
            }
            else if (other.CompareTag("Player1") || other.CompareTag("Player2"))
            {
                other.SendMessage("DamageTaken", damage2);
                //DestroyBullet();
            }
        }  
    }
}
