using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

	Animator ani;
	public float TimeCost;
	public GameObject Text;

	// Use this for initialization
	void Start () {
		TimeCost = 30f;
		ani = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (TimeCost > 1) {
			TimeCost -= Time.deltaTime;
		}

		if (TimeCost < 1) {
			ani.SetBool ("둥실둥실", false);
			ani.SetBool ("뒤로빠지고앞에서달려오기", true);

			Invoke ("sceanGO", 3);
		}
	}

	void sceanGO() {
		Text.SetActive (false);
		GameObject.Find ("GameClear").transform.Find ("GameClearPanel").gameObject.SetActive (true);
		Time.timeScale = 0.0f;
	}
}
