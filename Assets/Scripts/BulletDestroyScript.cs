using UnityEngine;
using System.Collections;

public class BulletDestroyScript : MonoBehaviour 
{
	void Start () 
	{
		Destroy (gameObject, 2f);
	}
}
