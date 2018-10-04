using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pressR : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void reset(){
		GameController.score = 0;
		GameController.rate = 70;
		GameController.heartNum = 0;
		playerController.bullet = 0;
		enemyMover.speed = 3f;
		boss1controller.damage = 0;
		boss1controller.clared = 0;
		boss2controller.damage = 0;
		boss2controller.clared = 0;
		boss3controller.damage = 0;
		boss3controller.clared = 0;
	}
}
