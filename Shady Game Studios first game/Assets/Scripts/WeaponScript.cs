using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {

    public Transform gunpoint;
    public GameObject bullet;
    private float bulletSpeed;

	// Use this for initialization
	void Start ()
    {
        bulletSpeed = 50;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            GameObject bulletInstance = (GameObject)Instantiate(bullet, gunpoint.position, Quaternion.identity);

            bulletInstance.GetComponent<Rigidbody>().AddForce(transform.up * bulletSpeed, ForceMode.Impulse);//velocity = bulletInstance.transform.forward * bulletSpeed;
        }
	}
}