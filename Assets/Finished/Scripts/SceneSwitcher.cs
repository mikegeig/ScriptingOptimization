using UnityEngine;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {

	public int levelToLoad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		   Application.LoadLevel(levelToLoad);
	}
}
