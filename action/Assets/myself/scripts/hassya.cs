using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hassya : MonoBehaviour {
	public AudioClip has;
	private AudioSource ad2;

	void Start () {
		ad2 = gameObject.GetComponent<AudioSource>();
		ad2.clip = has;

	}
	

	void Update () {
		if (GameController.aud == 1) {
			ad2.Play ();
			GameController.aud = 0;
		}
	}
}
