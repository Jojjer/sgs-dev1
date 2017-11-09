using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;

	// Use this for initialization
	void Start ()
    {
        for(int i = 0; i < 20; i++)
        {
            Vector3 position = new Vector3(Random.Range(-20.0f, 20.0f), 2f, Random.Range(70.0f, 50.0f));

            Instantiate(enemy, position, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
}
