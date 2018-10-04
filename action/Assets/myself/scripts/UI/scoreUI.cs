using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUI : MonoBehaviour {

	public Text scoreManager;
	public Text candyNumber;

	void Start () {
		scoreManager.text = "Score: " + 0.ToString();
		candyNumber.text = "× " + 0.ToString ();
	}

	void Update () {
		scoreManager.text = "Score: " + GameController.score.ToString ();
		candyNumber.text = "× " + playerController.bullet.ToString ();
	}
}
