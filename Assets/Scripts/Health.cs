﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float current_health = 100;
    public float max_health = 100;
    public UnityEvent OnDamageTaken;
    public UnityEvent OnDead;

    void DamageTaken(float amount)
    {
        current_health -= amount;
        OnDamageTaken.Invoke();
        if(current_health <= 0)
        {
            //SceneManager.LoadScene("ucaman_scene");
            OnDead.Invoke();
        }
    }
}
