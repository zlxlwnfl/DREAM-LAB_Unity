using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	Animator ani;
	public GameObject Text;
	public GameObject heart1;
	public GameObject heart2;

	int heart;

	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();
		heart = 2;
	}

	void Update () {
		MoveCharacter ();

		AnimationUpdate ();

		pausePress ();
	}

	void MoveCharacter(){
		ani.SetBool ("run", false);

		if (Input.GetKeyDown (KeyCode.W)) {
			ani.SetBool ("jump", true);
		} else {
			ani.SetBool ("jump", false);
		}

		if (Input.GetKey (KeyCode.S)) {
			ani.SetBool ("slide", true);
		} else {
			ani.SetBool ("slide", false);
		}
	}

	void AnimationUpdate(){
		ani.SetBool ("run", true);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (heart == 2) {
			ani.SetBool ("hit", true);
			heart--;
			heart2.SetActive (false);
			return;
		}

		heart1.SetActive (false);
		ani.SetBool ("death", true);
		Invoke ("sceanGO", 1);
	}

	void sceanGO() {
		Text.SetActive (false);
		GameObject.Find ("GameOver").transform.Find ("GameOverPanel").gameObject.SetActive (true);
		Time.timeScale = 0.0f;
	}

	void pausePress() {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			GameObject.Find ("Pause").transform.Find ("PausePanel").gameObject.SetActive (true);
			Time.timeScale = 0.0f;
		}
	}
}