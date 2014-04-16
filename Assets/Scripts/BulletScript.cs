using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float speed = 5;

	void Start()
	{
		for(int i = 0; i < 1000; i++)
		{}
	}


	void Update () 
	{
		transform.Translate(0, speed * Time.deltaTime, 0);
	}
}
