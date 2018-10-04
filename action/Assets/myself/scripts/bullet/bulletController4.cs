﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController4 : MonoBehaviour {

	float speed = 10f;
	Vector2 dir = new Vector2 (-0.28f, -0.96f);

	void Start () {
	}

	void Update () {
		transform.Translate (dir * speed * Time.deltaTime);
		if (transform.position.y <= -6f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag != "boss1" && other.tag != "boss3" && other.tag != "candy") {
			Destroy (this.gameObject);
		}
		if (other.tag == "enemy") {
			Destroy (other.gameObject);
		}
		if (other.tag == "Player") {
			GameController.heartNum++;
		}
	}
}
