using UnityEngine;
using System.Collections;

public class BulletFireScript : MonoBehaviour {
	
	public float fireTime = .05f;
	public GameObject bullet;

	void Start () {
		InvokeRepeating("Fire", fireTime, fireTime);
	}

	void Fire()
	{
		Instantiate(bullet, transform.position, Quaternion.identity);
	}
}
