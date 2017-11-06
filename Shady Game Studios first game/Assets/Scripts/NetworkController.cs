using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkController : NetworkBehaviour {

    public GameObject hostPlayerPrefab;
    public GameObject remotePlayerPrefab;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        var player = (GameObject)GameObject.Instantiate(remotePlayerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        if (isServer)
        {
            player = (GameObject)GameObject.Instantiate(hostPlayerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }
}
