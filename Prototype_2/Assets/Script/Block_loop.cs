using UnityEngine;
using System.Collections;

public class Block_loop : MonoBehaviour {
	public float Speed=3;
	public GameObject []Block;  //make block
	public GameObject A_Zone;   //middle block
	public GameObject B_Zone;   //Right of Screen Block
	private int A=0;

	void Update(){
		Move ();

	}
	void LateUpdate(){




	}
	void Move(){
		A_Zone.transform.Translate (Vector3.left * Speed * Time.deltaTime);  
		B_Zone.transform.Translate (Vector3.left * Speed * Time.deltaTime);  
		if (B_Zone.transform.position.x <= -6) {    
			DestroyImmediate(A_Zone);
			A_Zone = B_Zone;
			Make();
		}
	}
	void Make(){
	//	int A = Random.Range (0, Block.Length);
		B_Zone = Instantiate (Block[0], new Vector3 (A_Zone.transform.position.x+15, -3, 0), transform.rotation)
			as GameObject;
	}
}

