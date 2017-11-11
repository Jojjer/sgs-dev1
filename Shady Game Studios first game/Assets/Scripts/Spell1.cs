using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell1 : MonoBehaviour {

    //private Health dmg;

    // Use this for initialization
	void Start ()
    {
        //dmg = GameObject.FindObjectOfType(typeof(Health)) as Health;
        //dmg.DamageAttacker(50);
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0.5f, 0.0f, 0.0f);
	}

    private void OnCollisionEnter(Collision col)
    {

        //Destroy(this.gameObject);
    }
}
