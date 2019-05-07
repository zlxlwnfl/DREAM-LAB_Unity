using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_delete : MonoBehaviour {

	public GameObject Obstacle;
	public float _timerForDel;
	public float _timerForDelLim = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_timerForDel +=	Time.deltaTime;
		if (_timerForDel > _timerForDelLim) {
			Destroy (Obstacle);
			_timerForDel = 0;
			print ("Delete!");
		}
	}
}
