using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_move : MonoBehaviour {

	public float _speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (_speed * Time.deltaTime, 0, 0);

		if (transform.localPosition.x < -5.6f) {
			transform.localPosition = new Vector3 (5.73f, -0.012f, 0);
		}
	}
}
