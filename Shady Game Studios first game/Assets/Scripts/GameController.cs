using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject enemy;

	// Use this for initialization
	void Start ()
    {
        for(int i = 0; i < 5; i++)
        {
            Vector3 position = new Vector3(Random.Range(-25.0f, 25.0f), 2f, Random.Range(25.0f, 15.0f));

            Instantiate(enemy, position, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
}
