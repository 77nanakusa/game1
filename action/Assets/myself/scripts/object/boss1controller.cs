using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss1controller : MonoBehaviour {

	float x, y;
	int a;
	public static int b;
	public static int damage = 0;
	public static int clared = 0;
	public GameObject bullet, bullet1;
	public Transform ob1, ob2, ob3, ob4, ob5;

	void Start () {
		StartCoroutine ("mover");
		StartCoroutine ("attack");
	}

	void Update () {
		if (damage >= 3) {
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
			yield return new WaitForSeconds (3f);
		}
	}

	IEnumerator attack(){
		yield return new WaitForSeconds (1);
		while (true) {
				attack1 ();
			yield return new WaitForSeconds (3);
		}
	}

	void attack1(){
		Instantiate (bullet, ob1.position, Quaternion.identity);
		Instantiate (bullet, ob2.position, Quaternion.identity);
		Instantiate (bullet, ob3.position, Quaternion.identity);
		Instantiate (bullet, ob4.position, Quaternion.identity);
		Instantiate (bullet, ob5.position, Quaternion.identity);
	}
}
