using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ghostScript : MonoBehaviour
{
    public GameObject target,target1,target2; //este es el player (jugador)
    NavMeshAgent agent;//referencia para el ghost navmeshagent component
    Vector3 origen;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        origen = agent.transform.position;
        if(target == null)
        {
            target1 = GameObject.FindGameObjectWithTag("Player1");
            target2 = GameObject.FindGameObjectWithTag("Player2");
            target = target1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector3.Distance(agent.transform.position, target1.transform.position))> (Vector3.Distance(agent.transform.position, target2.transform.position)))
        {
            target = target2;
        }
        else
        {
            target = target1;
        }
        //utilizado para actualizar la localizacion
        agent.destination = target.transform.position;

    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            agent.transform.position = origen;
            //SceneManager.LoadScene("ucaman_scene");
        }
    }

    public void OndeadHandler()
    {
        Destroy(gameObject);
    }
}
