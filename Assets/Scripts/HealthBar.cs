using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Health health;
    void Start()
    {
        health = GetComponentInParent<Health>();
        
    }

    public void UpdateHealth()
    {
        float x = health.current_health / health.max_health;
        transform.localScale = new Vector3(x, 1, 1);
    }
}
