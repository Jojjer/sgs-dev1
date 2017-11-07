using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Health : NetworkBehaviour {

    public GameObject wall;
    public GameObject attacker;
    public const int maxWallHealth = 1000;
    public const int maxAttackerHealth = 50;
    [SyncVar]
    public int currentWallHealth = maxWallHealth;
    public int currentAttackerHealth = maxAttackerHealth;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void takeDamage(int damage, string target)
    {
        if (!isServer)
        {
            return;
        }
        switch (target)
        {
            case "wall":
                currentWallHealth -= damage;
                break;
            case "attacker":
                currentAttackerHealth -= damage;
                break;
        }
        if (currentAttackerHealth <= 0)
        {
            Destroy(attacker);
        }
        if (currentWallHealth <= 0)
        {
            Destroy(wall);
        }
    }
}