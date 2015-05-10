using UnityEngine;
using System.Collections;

public class Game_maneger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//mobile
		Screen.orientation = ScreenOrientation.Landscape;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.platform==RuntimePlatform.Android){
			if(Input.GetKeyDown(KeyCode.Escape)){
				Application.LoadLevel ("IntroScene");	
			}
	
	}
}
}