using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ghostScript : MonoBehaviour
{
    public GameObject target; //este es el player (jugador)
    NavMeshAgent agent;//referencia para el ghost navmeshagent component

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if(target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //utilizado para actualizar la localizacion
        agent.destination = target.transform.position;

    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("ucaman_scene");
        }
    }

    public void OndeadHandler()
    {
        Destroy(gameObject);
    }
}
