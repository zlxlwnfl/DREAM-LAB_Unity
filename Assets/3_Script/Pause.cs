using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		pauseDelete ();
	}

	void pauseDelete() {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			Time.timeScale = 1.0f;
			gameObject.SetActive (false);
		}
	}
}
