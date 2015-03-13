using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	private float Speed=0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, Speed * Time.deltaTime * 4f, 0);
	
	}
}
