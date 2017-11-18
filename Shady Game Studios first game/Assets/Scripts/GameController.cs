using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GameController : NetworkBehaviour
{

    public GameObject enemyprefab;

    private int amountOfEnemies;
    private string enemytype;

    // Use this for initialization
    void Start()
    {
<<<<<<< HEAD
        /* for (int i = 0; i < 5; i++)
         {
             Vector3 position = new Vector3(Random.Range(-25.0f, 25.0f), 2f, Random.Range(25.0f, 15.0f));

             Instantiate(enemy, position, Quaternion.identity);
         }*/

    }

    // Update is called once per frame
    void Update()
=======
        for(int i = 0; i < 10; i++)
        {
            Vector3 position = new Vector3(Random.Range(-20.0f, 20.0f), 2f, Random.Range(70.0f, 50.0f));

            Instantiate(enemy, position, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
>>>>>>> Fredrik
    {

    }
}