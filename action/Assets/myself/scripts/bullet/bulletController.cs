using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {

	float speed = 10f;

	void Start () {
		
	}

	void Update () {
		transform.Translate (Vector2.up * speed * Time.deltaTime);
		if (transform.position.y >= 16f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag != "Player" && other.tag != "candy") {
			Destroy (this.gameObject);
		}
		if (other.tag == "enemy") {
			Destroy (other.gameObject);
		}
		if (other.tag == "boss1") {
			boss1controller.damage++;
		}
		if (other.tag == "boss2") {
			boss2controller.damage++;
		}
		if (other.tag == "boss3") {
			boss3controller.damage++;
		}
	}
}
