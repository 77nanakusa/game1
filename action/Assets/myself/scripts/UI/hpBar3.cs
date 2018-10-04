using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpBar3 : MonoBehaviour {

	Slider sec;

	void Start () {
		sec = GameObject.Find ("hpbar2nd").GetComponent<Slider> ();
	}

	void Update () {
		sec.value = 10 - boss2controller.damage;
	}
}
