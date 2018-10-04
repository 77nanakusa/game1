using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameoverr : MonoBehaviour {
	
	public AudioClip gameover;
	private AudioSource ad4;

	void Start () {
		ad4 = gameObject.GetComponent<AudioSource>();
		ad4.clip = gameover;
		ad4.Play ();
	}
}
