using UnityEngine;
using System.Collections;
using PDollarGestureRecognizer;

public class Store_gui : MonoBehaviour {
	private string message="Store";
	private int fontsize = 30;
	// Use this for initialization
	void Start () {


	}

	void LateUpdte(){

	}
	// Update is called once per frame
	void Update () {
		Debug.Log (PlayerPrefs.GetInt ("gold"));
	}
	void OnGUI(){
		GUI.Label (new Rect (Screen.width/2-50, 10,80 , 40),message);
		GUI.skin.label.fontSize = fontsize;
		GUI.Label (new Rect (Screen.width - 150, 10, 100, 40),"Gold : ");

	}
}
