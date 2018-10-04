using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainController : MonoBehaviour {

	float speed = 30f;

	void Start () {
		
	}

	void Update () {
		transform.Translate (Vector2.down * speed * Time.deltaTime);

		if (transform.position.y <= -6f) {
			Destroy (this.gameObject);
		}
	}
}
