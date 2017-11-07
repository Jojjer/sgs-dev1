using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {


    private GameObject shades;
    private MeshRenderer myMeshRenderer;
    private MeshRenderer childMeshRenderer;

    // Use this for initialization
    void Start ()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        shades = transform.Find("Cube").gameObject;
        childMeshRenderer = shades.GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update ()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        if (!isServer)
        {
            myMeshRenderer.enabled = false;
            childMeshRenderer.enabled = false;            
        }
    }
}
