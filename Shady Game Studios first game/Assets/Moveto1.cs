using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Moveto1 : MonoBehaviour
{

    public Transform Enemy;

    public Transform goal;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector3 position = new Vector3(Random.Range(-25.0f, 25.0f), 2f, Random.Range(25.0f, 15.0f));

            Instantiate(Enemy, position, Quaternion.identity);
        }
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;

    }
}
