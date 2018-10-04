using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss3controller : MonoBehaviour {

	float x, y;
	int a;
	public static int b;
	public static int damage = 0;
	public static int clared = 0;
	public GameObject bul, bul2, bul3, bul4, bul5, bul6, train;
	public Transform ob, ob1, ob2, ob3, ob4, ob5;
	bool atk = true;
	public AudioClip has;
	private AudioSource ad2;

	void Start () {
		ad2 = gameObject.GetComponent<AudioSource>();
		ad2.clip = has;
		StartCoroutine ("mover");
	}

	void Update () {
		if (atk == true) {
			a = Random.Range (1, 4);
			if (a == 1) {
				atk = false;
				attack1 ();
			} else if (a == 2) {
				atk = false;
				attack2 ();
			} else if (a == 3) {
				atk = false;
				attack3 ();
			} else {
			}

		}
		if (damage >= 20) {
			Destroy (this.gameObject);
			clared = 1;
		}
	}

	IEnumerator mover(){
		while (true) {
			x = Random.Range (-5f, 5f);
			y = Random.Range (10f, 13.5f);
			Vector3 movement = new Vector3(x, y, 0f);
			transform.position = movement;
			yield return new WaitForSeconds (3);
		}
	}

	void attack1(){
		StartCoroutine ("atk1");
	}

	void attack2(){
		StartCoroutine ("atk2");
	}

	void attack3(){
		StartCoroutine ("atk3");
	}

	IEnumerator atk1(){
		for (int i = 0; i < 3; i++) {
			Instantiate (bul3, ob.position, Quaternion.identity);
			Instantiate (bul4, ob.position, Quaternion.identity);
			Instantiate (bul5, ob.position, Quaternion.identity);
			yield return new WaitForSeconds (0.3f);
		}
		yield return new WaitForSeconds (1f);
		atk = true;
	}

	IEnumerator atk2(){
		yield return new WaitForSeconds (2);
		ad2.Play ();
		yield return new WaitForSeconds (1);
		Instantiate (train, ob1.position, Quaternion.identity);
		Instantiate (train, ob3.position, Quaternion.identity);
		Instantiate (train, ob5.position, Quaternion.identity);
		yield return new WaitForSeconds (1.25f);
		Instantiate (train, ob2.position, Quaternion.identity);
		Instantiate (train, ob4.position, Quaternion.identity);
		yield return new WaitForSeconds (1.25f);
		Instantiate (train, ob1.position, Quaternion.identity);
		Instantiate (train, ob3.position, Quaternion.identity);
		Instantiate (train, ob5.position, Quaternion.identity);
		yield return new WaitForSeconds (1f);
		atk = true;
	}

	IEnumerator atk3(){
		yield return new WaitForSeconds (1f);
		Instantiate (bul6, ob1.position, Quaternion.identity);
		Instantiate (bul6, ob3.position, Quaternion.identity);
		Instantiate (bul6, ob5.position, Quaternion.identity);
		yield return new WaitForSeconds (0.4f);
		Instantiate (bul6, ob2.position, Quaternion.identity);
		Instantiate (bul6, ob4.position, Quaternion.identity);
		yield return new WaitForSeconds (1.5f);
		atk = true;
	}
}
