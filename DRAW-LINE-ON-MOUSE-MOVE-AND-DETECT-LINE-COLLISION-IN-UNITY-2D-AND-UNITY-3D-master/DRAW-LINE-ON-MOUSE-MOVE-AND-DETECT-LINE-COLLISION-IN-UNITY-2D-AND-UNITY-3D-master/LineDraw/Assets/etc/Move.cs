using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public Animator Ani;
	private Rigidbody2D ri;
	//private bool canjump;
	public float MoveSpeed=0.1f;

	// Use this for initialization
	void Start () {
		ri = this.rigidbody2D;
	}
	
	// Update is called once per frame
	void Update () {
		//ri.velocity = new Vector2 (MoveSpeed, ri.velocity.y);
		//transform.Translate (MoveSpeed*Time.deltaTime*0.1f, 0,0 );
		//Ani.SetBool("JUMP00",false);
		//RaycastHit2D hit=Physics2D.Linecast(startpos
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			//	Ani.SetBool("JUMP00",true);
			//transform.Translate (0, MoveSpeed*Time.deltaTime*5f,0 );
			ri.velocity=new Vector2(ri.velocity.x-3,8);
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			//	Ani.SetBool("JUMP00",true);
			//transform.Translate (0, MoveSpeed*Time.deltaTime*5f,0 );
			ri.velocity=new Vector2(ri.velocity.x+3,8);
		}
		if(Input.GetKeyDown(KeyCode.Space)){
		//	Ani.SetBool("JUMP00",true);
			//transform.Translate (0, MoveSpeed*Time.deltaTime*5f,0 );
			ri.velocity=new Vector2(ri.velocity.x,8);
	}
	}
}
