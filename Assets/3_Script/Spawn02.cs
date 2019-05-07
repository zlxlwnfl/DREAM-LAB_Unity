using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn02 : MonoBehaviour {

	public GameObject Obstacle;
	public float respawnTime = 7;
	private float time = 0;
	public float TimeCost;

	// Use this for initialization
	void Start () {
		Instantiate (Obstacle, transform.position, transform.rotation);
		TimeCost = 25f;
	}

	// Update is called once per frame
	void Update () {
		if (TimeCost > 1) {
			TimeCost -= Time.deltaTime;	

			time += Time.deltaTime;

			if (time > respawnTime) {
				time = 0;
				Instantiate (Obstacle, new Vector3 (33, (1), 0), Quaternion.Euler (new Vector3 (0, 0, 0)));
			}
		}
	}
}