using UnityEngine;
using System.Collections;

public class Show : MonoBehaviour {
	private Rect rect;
	private PlayerState P;
	// Use this for initialization
	void Start () {
		rect = new Rect (0,0,Screen.width,Screen.height);
		//P = GetComponent<Player> ().PS;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (P);
	}
	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2-40, Screen.height / 2-100, 80, 40), "STORE")) {
			Debug.Log ("STORE Pressed");
			Application.LoadLevel("STORE");
		}
		if (GUI.Button (new Rect (Screen.width / 2-40, Screen.height / 2-40, 80, 40), "START")) {
			Debug.Log ("START Pressed");
			Application.LoadLevel("Play");
		}
		if (GUI.Button (new Rect (Screen.width / 2-40, Screen.height / 2+20, 80, 40), "Setting")) {
			Debug.Log ("Setting Pressed");

		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel("IntroScene");
		}

		//GUI.Button (new Rect (Screen.width - 100, 10, 100, 30), "Recognize");
	}
}
