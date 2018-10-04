using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController8 : MonoBehaviour {

	float speed = -3f;

	void Start () {
		StartCoroutine ("fall");
	}

	void Update () {
		speed -= 0.1f;
		transform.Translate (Vector2.up * speed * Time.deltaTime);
		if (transform.position.y <= -6f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag != "boss1" && other.tag != "candy" && other.tag != "boss2" && other.tag != "boss3") {
			Destroy (this.gameObject);
		}
		if (other.tag == "enemy") {
			Destroy (other.gameObject);
		}
		if (other.tag == "Player") {
			GameController.heartNum++;
		}
	}

	IEnumerator fall(){
		yield return new WaitForSeconds (2f);
	}
}
