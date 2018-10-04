using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpBar1 : MonoBehaviour {

	Slider ota;

	void Start () {
		ota = GameObject.Find ("hpbarOtaku").GetComponent<Slider> ();
	}

	void Update () {
		ota.value = 3 - boss1controller.damage;
	}
}
