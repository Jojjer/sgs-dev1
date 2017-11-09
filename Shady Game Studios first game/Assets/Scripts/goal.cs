using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class goal : MonoBehaviour {

    public Transform walktodoor;

    // Use this for initialization
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = /*new Vector3(-1, 2, -18);*/walktodoor.position;
    }
    
	
}
