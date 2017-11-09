using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour {

    public Transform movetogoal;
    public Transform Enemy;

    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector3 position = new Vector3(Random.Range(-25.0f, 25.0f), 2f, Random.Range(25.0f, 15.0f));
            Instantiate(Enemy, position, Quaternion.identity);
        }
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = movetogoal.position;
    }
}
