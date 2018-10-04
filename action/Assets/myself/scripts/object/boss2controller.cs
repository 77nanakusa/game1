using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2controller : MonoBehaviour {

	float x, y;
	int a;
	public static int b;
	public static int damage = 0;
	public static int clared = 0;
	public GameObject bul, bul2, bul3, bul4;
	public Transform ob, ob2, ob3, ob4, ob5;

	void Start () {
		StartCoroutine ("mover");
		StartCoroutine ("attack");
	}

	void Update () {
		if (damage >= 10) {
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
			yield return new WaitForSeconds (2f);
		}
	}

	IEnumerator attack(){
		yield return new WaitForSeconds (0.5f);
		while (true) {
			a = Random.Range (1, 3);
			if (a == 1) {
				attack1 ();
			}
			if (a == 2) {
				attack2 ();
			}
			yield return new WaitForSeconds (2.5f);
		}
	}

	void attack1(){
		StartCoroutine ("atk1");
	}

	void attack2(){
		b = Random.Range (1, 4);
		Instantiate (bul4, ob.position, Quaternion.identity);
		Instantiate (bul4, ob2.position, Quaternion.identity);
		Instantiate (bul4, ob3.position, Quaternion.identity);
		Instantiate (bul4, ob4.position, Quaternion.identity);
		Instantiate (bul4, ob5.position, Quaternion.identity);
	}

	IEnumerator atk1(){
		for (int i = 0; i < 2; i++) {
			Instantiate (bul, ob.position, Quaternion.identity);
			Instantiate (bul2, ob.position, Quaternion.identity);
			Instantiate (bul3, ob.position, Quaternion.identity);
			yield return new WaitForSeconds (0.2f);
		}
	}
}
