using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController2 : MonoBehaviour {

	float speed = 2f;
	Vector3 dir = new Vector3 (0f, 3.2f, 0f);
	public GameObject player;


	void Start () {
		if (boss2controller.b == 1) {
			dir.x = 3f - transform.position.x;
			dir.y = 3f - transform.position.y;
		}
		if (boss2controller.b == 2) {
			dir.x = -3f - transform.position.x;
			dir.y = 3f - transform.position.y;
		}
		if (boss2controller.b == 3) {
			dir.x = 0f - transform.position.x;
			dir.y = 3f - transform.position.y;
		}
	}

	void Update () {

		transform.Translate (dir * speed * Time.deltaTime);

		if (transform.position.y <= -6f) {
			Destroy (this.gameObject);
		}
		if (transform.position.y >= 16f) {
			Destroy (this.gameObject);
		}
		if (transform.position.x >= 10f) {
			Destroy (this.gameObject);
		}
		if (transform.position.x <= -10f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag != "boss1" && other.tag != "candy") {
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
