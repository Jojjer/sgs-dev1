using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private Transform door;

	// Use this for initialization
	void Start ()
    {
        door = GameObject.Find("Door").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(door);

        //transform.Rotate(Vector3.back * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * 2);
	}
}
