using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			GameObject.Find ("Stage1StartCanvas").transform.Find ("Stage1StartPanel").gameObject.SetActive (false);
			Time.timeScale = 1.0f;
		}
	}
}
