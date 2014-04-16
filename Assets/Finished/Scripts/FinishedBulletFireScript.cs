using UnityEngine;
using System.Collections;

public class FinishedBulletFireScript : MonoBehaviour {
	
	public float fireTime = .05f;
	
	void Start () {
		InvokeRepeating("Fire", fireTime, fireTime);
	}
	
	void Fire()
	{
		GameObject obj = ObjectPoolerScript.current.GetPooledObject();

		if(obj == null) return;

		obj.transform.position = transform.position;
		obj.transform.rotation = Quaternion.identity;
		obj.SetActive(true);
	}
}
