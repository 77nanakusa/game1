using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	Vector2 dir;
	public float speed;
	public static int bullet = 0;
	public GameObject bul;
	public Transform launcher;
	public AudioClip has;
	private AudioSource ad2;

	void Start () {
		ad2 = gameObject.GetComponent<AudioSource>();
		ad2.clip = has;
	}
		
	void Update () {
		//移動
		if (Input.GetKey (KeyCode.W)) {
			dir = Vector2.up * Time.deltaTime * speed;
			move(dir);
		}		
		if (Input.GetKey (KeyCode.S)) {
			dir = Vector2.down * Time.deltaTime * speed;
			move(dir);
		}
		if (Input.GetKey (KeyCode.A)) {
			dir = Vector2.left * Time.deltaTime * speed;
			move(dir);
		}
		if (Input.GetKey (KeyCode.D)) {
			dir = Vector2.right * Time.deltaTime * speed;
			move(dir);
		}
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -6.4f, 6.4f), Mathf.Clamp (transform.position.y, -4.5f, 14.5f), 0.0f);

		//攻撃
		if(Input.GetKeyDown(KeyCode.Space) && bullet >= 1){
			Instantiate (bul, launcher.position, launcher.rotation);
			bullet--;
			ad2.Play ();
		}
	}

	void move (Vector2 vec){
		transform.Translate (vec);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "enemy" || other.tag == "boss" || other.tag == "boss1") {
			GameController.heartNum++;
		}
		if (other.tag == "candy") {
			bullet += 3;
			Destroy (other.gameObject);
		}
	}
}