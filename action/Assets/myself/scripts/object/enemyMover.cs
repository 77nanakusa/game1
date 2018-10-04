using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMover : MonoBehaviour {

	public static float speed = 3f;

	void Start () {
		
	}

	void Update () {
		transform.Translate (Vector2.down * speed * Time.deltaTime);

		if (transform.position.y <= -6f) {
			Destroy (this.gameObject);
		}
	}
}
