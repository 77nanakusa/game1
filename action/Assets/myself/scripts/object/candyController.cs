using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyController : MonoBehaviour {
	float speed = 10f;

	void Start () {

	}

	void Update () {
		transform.Translate (Vector2.down * speed * Time.deltaTime);
		if (transform.position.y <= -6f) {
			Destroy (this.gameObject);
		}
	}
}
