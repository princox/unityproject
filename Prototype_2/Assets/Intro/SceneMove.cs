using UnityEngine;
using System.Collections;

public class SceneMove : MonoBehaviour {
	
	public string SceneName;
	void Start () {
		//mobile
		Screen.orientation = ScreenOrientation.Landscape;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	void update(){

	}
	public void OnMouseDown(){
		
		Application.LoadLevel ("Main");		
		
	}
	
}


	

