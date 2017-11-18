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
    public int currentWallHealth = maxAttackerHealth;
    public int currentAttackerHealth = maxWallHealth;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(currentAttackerHealth);
        Debug.Log(currentWallHealth);
        
        if (currentAttackerHealth == 0)
        {
            Debug.Log("Attacker died!");
            //Destroy(attacker);
        }
        if (currentWallHealth == 0)
        {
            Debug.Log("Wall died!");
            //Destroy(wall);
        }
    }
    
    public void DamageWall(int damage)
    {
        if (!isServer)
        {
            return;
        }

        currentWallHealth -= damage;
    }
    public void DamageAttacker(int damage)
    {
        if (!isServer)
        {
            return;
        }

        currentAttackerHealth -= damage;
    }
}