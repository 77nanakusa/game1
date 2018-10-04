using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpBar2 : MonoBehaviour {

	Slider achi;

	void Start () {
		achi = GameObject.Find ("hpbarAchikita").GetComponent<Slider> ();
	}

	void Update () {
		achi.value = 20 - boss3controller.damage;
	}
}
