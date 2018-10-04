using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size : MonoBehaviour {
	public int ScreenWidth = 600;
	public int ScreenHeight = 900;
	void Awake(){
		// PC向けビルドだったらサイズ変更
		if (Application.platform == RuntimePlatform.WindowsPlayer ||
			Application.platform == RuntimePlatform.OSXPlayer ||
			Application.platform == RuntimePlatform.LinuxPlayer )
		{
			Screen.SetResolution(ScreenWidth, ScreenHeight, false);
		}
	}

}
