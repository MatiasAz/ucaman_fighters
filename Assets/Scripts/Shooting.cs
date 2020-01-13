using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
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
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Instantiate(bullet, transform.position, transform.rotation);
        }
    }
    void Shot()
    {
        GameObject instbullet = Instantiate(bullet, transform.position, transform.rotation);
    }
}
