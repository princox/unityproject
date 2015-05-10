using UnityEngine;
using System.Collections;

public class offset_map : MonoBehaviour { //background position
	public GameObject player;
	private Vector3 offset;
	private Vector3 playeroffset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
		playeroffset = new Vector3 (player.transform.position.x
		                                   ,player.transform.position.y,player.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		playeroffset = new Vector3 (player.transform.position.x+10
		                            ,0,player.transform.position.z);
		transform.position = playeroffset+ offset;
		
		
	}
}
