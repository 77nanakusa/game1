using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour {

	void Start () {
		
	}

	void Update () {

	}

	public void startBut(){
		SceneManager.LoadScene ("GameScene");
	}
	public void expBut(){
		SceneManager.LoadScene ("explainScene");
	}
	public void creBut(){
		SceneManager.LoadScene ("creditScene");
	}
	public void menuBut(){
		SceneManager.LoadScene ("startScene");
	}
}
