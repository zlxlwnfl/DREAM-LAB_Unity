using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
		
	public float movespeed = 0.7f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float MoveX = -1 * movespeed * Time.deltaTime;

		transform.Translate (MoveX, 0, 0);
	}
}
