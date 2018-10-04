using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidan : MonoBehaviour {

	int hidann;
	public AudioClip has;
	private AudioSource ad2;

	void Start () {
		ad2 = gameObject.GetComponent<AudioSource>();
		ad2.clip = has;
	}

	void Update () {
		if (GameController.heartNum != hidann) {
			ad2.Play ();
			hidann = GameController.heartNum;
		}
	}
}
