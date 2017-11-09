using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class UIHandler : NetworkBehaviour {

    public GameObject enemyprefab;

    public InputField NumberOfEnemies;

    private int enemyAmount;

    [Command]
    public void CmdButtonClick()
    {
        enemyAmount = int.Parse(NumberOfEnemies.text);
        for (int i = 0; i < enemyAmount; i++)
        {
            Vector3 position = new Vector3(Random.Range(-25.0f, 25.0f), 2f, Random.Range(25.0f, 15.0f));
            var enemy = (GameObject)Instantiate(enemyprefab, position, Quaternion.identity);
            NetworkServer.Spawn(enemy);
        }
    }

}

