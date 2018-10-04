using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject ene, can, boss1, boss2, boss3, lastBoss, heart1, heart2, heart3, damage1, damage2, damage3, player, barOtaku, bar2nd, barAchi;
	int num, spawnRate, candyRate, candyPos;
	public static float rate = 70f;
	public static int score = 0, aud = 0;
	Vector3 bossGenerate = new Vector3(0f, 16f, 0f);
	Vector3 Generate = new Vector3(0f, 0f, 0f);
	public static int heartNum = 0;
	public AudioClip bgm;
	private AudioSource audioSource1;


	void Start () {
		audioSource1 = gameObject.GetComponent<AudioSource>();
		audioSource1.clip = bgm;
		audioSource1.Play ();

		Instantiate (player, Generate, Quaternion.identity);
		StartCoroutine ("enemy");
		StartCoroutine ("candy");
		spawnRate = 30;

		barOtaku.gameObject.SetActive(false);
		bar2nd.gameObject.SetActive(false);
		barAchi.gameObject.SetActive(false);
		heart1.GetComponent<Image> ().enabled = true;
		damage1.GetComponent<Image> ().enabled = false;
		heart2.GetComponent<Image> ().enabled = true;
		damage2.GetComponent<Image> ().enabled = false;
		heart3.GetComponent<Image> ().enabled = true;
		damage3.GetComponent<Image> ().enabled = false;
	}

	void Update () {
		score += Mathf.FloorToInt(Time.deltaTime * rate);

		if (heartNum == 1) {
			heart1.GetComponent<Image> ().enabled = false;
			damage1.GetComponent<Image> ().enabled = true;
		}
		if (heartNum == 2) {
			heart2.GetComponent<Image> ().enabled = false;
			damage2.GetComponent<Image> ().enabled = true;
		}
		if (heartNum >= 3) {
			SceneManager.LoadScene ("GameOverScene");
		}

	}

	IEnumerator enemy(){
		yield return new WaitForSeconds (2f);
		while (true) {
			spawn (-5f);
			spawn (-2.5f);
			spawn (0f);
			spawn (2.5f);
			spawn (5f);
			yield return new WaitForSeconds (1.35f);
			if (score >= 3000) {
				break;
			}
		}
		yield return new WaitForSeconds (4f);
		aud = 1;
		yield return new WaitForSeconds (1f);
		spawnTrain (0f);

		enemyMover.speed = 4f;
		rate = 130f;
		while (true) {
			spawn (-5f);
			spawn (-2.5f);
			spawn (0f);
			spawn (2.5f);
			spawn (5f);
			yield return new WaitForSeconds (1f);
			if (score >= 7500) {
				break;
			}
		}
		yield return new WaitForSeconds (5f);
		barOtaku.gameObject.SetActive(true);
		Instantiate (boss2, bossGenerate, Quaternion.identity);
		while (boss1controller.clared == 0) {
			yield return new WaitForSeconds (1f);
		}
		score += 10000;
		barOtaku.gameObject.SetActive(false);
		enemyMover.speed = 6f;
		rate = 190f;
		while (true) {
			spawn (-5f);
			spawn (-2.5f);
			spawn (0f);
			spawn (2.5f);
			spawn (5f);
			yield return new WaitForSeconds (0.66f);
			if (score >= 25000) {
				break;
			}
		}
		yield return new WaitForSeconds (5f);
		bar2nd.gameObject.SetActive(true);
		Instantiate (boss3, bossGenerate, Quaternion.identity);
		while (boss2controller.clared == 0) {
			yield return new WaitForSeconds (1f);
		}
		score += 30000;
		bar2nd.gameObject.SetActive(false);
		enemyMover.speed = 7f;
		rate = 250f;
		while (true) {
			spawn (-5f);
			spawn (-2.5f);
			spawn (0f);
			spawn (2.5f);
			spawn (5f);
			yield return new WaitForSeconds (0.57f);
			if (score >= 80000) {
				break;
			}
		}
		yield return new WaitForSeconds (5f);
		barAchi.gameObject.SetActive(true);
		Instantiate (lastBoss, bossGenerate, Quaternion.identity);
		while (boss3controller.clared == 0) {
			yield return new WaitForSeconds (1f);
		}
		score += 50000;
		barAchi.gameObject.SetActive(false);
		enemyMover.speed = 8f;
		rate = 400f;
		while (true) {
			spawn (-5f);
			spawn (-2.5f);
			spawn (0f);
			spawn (2.5f);
			spawn (5f);
			yield return new WaitForSeconds (0.5f);
			if (score >= 140000) {
				enemyMover.speed = 9f;
				rate = 500f;
			}
			if (score >= 160000) {
				enemyMover.speed = 10f;
				rate = 1000f;
			}
		}

	}

	void spawn(float spawnx){
		Vector3 spawn = new Vector3(spawnx, 16f, 0f);
		num = Random.Range (1, 100);
		if (num <= spawnRate) {
			Instantiate (ene, spawn, Quaternion.identity);
		}
	}

	void spawnTrain(float spawnx){
		Vector3 spawn = new Vector3(spawnx, 16f, 0f);
		Instantiate (boss1, spawn, Quaternion.identity);
	}

	IEnumerator candy(){
		yield return new WaitForSeconds (5f);
		while (true) {
			Invoke ("candyMaker", 0f);
			yield return new WaitForSeconds (1f);
		}
	}

	void candyMaker(){
		candyRate = Random.Range (1, 100);
		candyPos = Random.Range (-3, 3);
		Vector3 candySpawn = new Vector3 (candyPos * 2f, 16f, 0f);
		if (candyRate <= 17) {
			Instantiate (can, candySpawn, Quaternion.identity);
		}
	}
}
