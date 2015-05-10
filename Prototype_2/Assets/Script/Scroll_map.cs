using UnityEngine;
using System.Collections;

public class Scroll_map : MonoBehaviour
{
	public float ScrollSpeed = 0.5f;
	float Target_Offset;
	
	void Update ()
	{
		//Debug.Log (Player.gold.ToString ());
		Target_Offset += Time.deltaTime * ScrollSpeed;
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Target_Offset,0 );
		
	}
}
