using UnityEngine;
using System.Collections;

public class Camera2DFollow : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	public float speed = 0.5f;
	float cameraSize=5f;
	public Camera camera;
	public float MaxSize=10f;
	public float MinSize=-5f;
	private Vector3 playeroffset;
	// Use this for initialization
	void Start () {
		
		Vector3 offset1 = new Vector3 (transform.position.x-7, 0, 0);
		offset = transform.position-offset1;
	}
	
	// Update is called once per frame
	void Update () {
		playeroffset = new Vector3 (player.transform.position.x
		                            , 0, player.transform.position.z);
		transform.position = playeroffset + offset;
		cameraSize = 5f + player.transform.position.y;
		//		cameraSize = 5f + player.transform.position.y;
		//		if(cameraSize>=MaxSize)
		//			cameraSize=MaxSize;
		//		if(cameraSize<=MinSize)
		//			cameraSize=MinSize;
		
		//	camera.orthographicSize = Mathf.Lerp (camera.orthographicSize, cameraSize, Time.deltaTime / speed);
		
		
	}
}