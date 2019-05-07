using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Dream lab

public class Timer : MonoBehaviour {
	
	public float TimeCost;

	// Use this for initialization
	void Start () {
		TimeCost = 30f;
	}
	
	// Update is called once per frame
	void Update () {
		if (TimeCost > 1) {
			TimeCost -= Time.deltaTime;	
		}

		int t = Mathf.FloorToInt (TimeCost);
		Text uiText = GetComponent<Text> ();
		uiText.text = t.ToString() + 's';
	}
}
