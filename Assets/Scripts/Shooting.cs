using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float shotCooldown = 0.25f;
    float lastShotTime = 0;
    //public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
                
    }
    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            GameObject.Instantiate(bullet, transform.position, transform.rotation);
        }
    }*/
    void Shot()
    {
        if(Time.time - lastShotTime > shotCooldown)
        {
            GameObject instbullet = Instantiate(bullet, transform.position, transform.rotation);
            lastShotTime = Time.time;
        }
        
    }
}
