using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	private float bulletSpeed;
	// Use this for initialization
	void Start () {
		bulletSpeed = -400f;
		GetComponent<Rigidbody>().AddForce(new Vector3(bulletSpeed,0,0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
