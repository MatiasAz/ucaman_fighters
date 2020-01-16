using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float shotCooldown = 0.5f;
    float lastShotTime = 0;
    int fire = 0;
    int bandera = 0;
    float inicio = 0f;
    //public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
       // {
       //     Shot();
       // }
       if((Time.time - inicio) < 10f && fire == 1)
        {
            Shot();
        }
        else
        {
            fire = 0;
        }
                
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Shot();
            fire = 1;
            inicio = Time.time;
        }
    }
    void Shot()
    {
        if(Time.time - lastShotTime > shotCooldown)
        {
            GameObject instbullet = Instantiate(bullet, transform.position, transform.rotation);
            lastShotTime = Time.time;
            
        }
        
    }
}
