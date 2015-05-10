using UnityEngine;
using System.Collections;
using PDollarGestureRecognizer;
public enum PlayerState{
	Run,
	Jump,
	D_Jump,
	Death,
	Idle
}
public class Player : MonoBehaviour {
	public static PlayerState PS; //플레이어 상태 변수 ps
	public float Jump_Power=450f;
	public AudioClip [] Sound;  //사운드 배열
	public Animation animation;   
	public Animator animator;
	public GameObject AnotherSpeaker;
	private Result gestureResult;
	public GameObject bullet;
	private GameObject destory;
	private GameObject coll;
	private Rect drawarea;
	public float timer;
	public int waitingTime;
	private int i=0;
	GameObject curbullet;


	void Start(){
		PlayerPrefs.SetInt ("gold",1000);
		//Static.gold = 1000;
		//PS = PlayerState.Run;
		//drawarea = GetComponent<Demo> ().drawArea;
		//Debug.Log (drawarea);
		animation = this.GetComponent<Animation> ();
		attack ();
		//player_store.gold = 1000;//소지금 설정
	}
	void Update(){
	}
	void LateUpdate () {
		//drawarea = new Rect(0, 0, Screen.width, Screen.height); 파괴할 오브젝트가 범위안에 있는지 
//		gestureResult=
		GetComponent<Rigidbody>().WakeUp ();  //리지드바디 지속적인 활성
	//	if (Input.GetKeyDown (KeyCode.Space)&&PS!=PlayerState.Death) {
		//PS = PlayerState.Run;
		//gestureResult = GetComponent<Demo> ().gestureResult;


	//	if(Input.GetMouseButtonDown(0)&&PS!=PlayerState.Death){

		if(Input.GetMouseButtonUp(0)){
			gestureResult = GetComponent<Demo> ().gestureResult;

			Debug.Log (gestureResult.GestureClass.ToString ());
			if(gestureResult.GestureClass=="down0"||gestureResult.GestureClass=="down1"){
				Debug.Log(PS.ToString());
				Jump ();
			}
			if(gestureResult.GestureClass=="up"||gestureResult.GestureClass=="up1"){
				destory=GameObject.FindGameObjectWithTag("up");
				animation.Play("air_kick");

				if(destory){

					Destroy(destory);
				}
				//if(drawarea.Contains(destory.transform.position)){
					
				//}
			}
			if(gestureResult.GestureClass=="circle0"||gestureResult.GestureClass=="circle1"){
				destory=GameObject.FindGameObjectWithTag("circle");
				animation.Play("combo_punch1");
				if(destory){

					Destroy(destory);
				}
				//if(drawarea.Contains(destory.transform.position)){

				//}
			}

		}
		if(PS==PlayerState.Jump){
				//D_Jump();
			}
			if(PS==PlayerState.Run){
				//Jump ();
			}
		}
	//}

	void Jump(){
		if (PS == PlayerState.Run) {
			PS = PlayerState.Jump;
			Debug.Log(PS.ToString());
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, Jump_Power, 0));
			//animation.Play("pre_jump");
	//		animator.SetTrigger("jump");

			animation.Play("fighting_jump");
	//		animation.Play("jump_landing");
		}
		//점프 함수 호출시 
		//SoundPlay (2);
//		AnotherSpeaker.SendMessage ("SoundPlay”); //추가한 sound의 스크립트에 SoundPlay 함수 호출
 //       animator.SetTrigger ("Jump”);   //animator 값을 점프로 변경
//		animator.SetBool ("Ground", false);  //animator 값 Ground를 false로 변경
	}
	void D_Jump(){
		PS = PlayerState.D_Jump;
		GetComponent<Rigidbody>().AddForce(new Vector3(0,Jump_Power,0));
		//    SoundPlay (2);
//		AnotherSpeaker.SendMessage ("SoundPlay");
//		animator.SetTrigger ("D_Jump");
//		animator.SetBool ("Ground", false);
	}
	void Run(){
		PS = PlayerState.Run;
//		animator.SetBool ("Ground", true);
//		animator.SetBool("Ground",true);
//		animator.SetTrigger("run");
	}
	void OnCollisionEnter(Collision collision){ // 충돌시에 실행되는 함수
		if(PS!=PlayerState.Run&&PS!=PlayerState.Death){
			Run();
		}
		//coll = GameObject.FindGameObjectsWithTag ("ground");
		if (collision.gameObject.tag == "ground") {
			animation.Play("run");
		//	animator.SetTrigger("run");
		}
		if (collision.gameObject.tag == "up" || collision.gameObject.tag == "circle") {
			Debug.Log (PS.ToString ());
			StartCoroutine (Die (0.01f));
			animation.Play ("dying");
		}

	}
	void CoinGet(){
		SoundPlay (0); //사운드 플레이
	}
	void GameOver(){
		PS = PlayerState.Death;

		Debug.Log ("GameOver");
		SoundPlay (1);
	}
	void SoundPlay(int Num){
		GetComponent<AudioSource>().clip = Sound [Num];
		GetComponent<AudioSource>().Play ();  //사운드 플레이
	}

	void OnTriggerEnter(Collider other){   //Trigger 충돌시 충돌 객체를 other 로 받아옴
		GetComponent<Rigidbody>().WakeUp ();  //리지드바디를 지속적으로 실행시키는 함수
		if (other.gameObject.name == "Coin") {  //other 객체의 이름이 coin 이면 실행
			Destroy (other.gameObject);
			CoinGet ();
		}
		if(other.gameObject.name=="DeathZone"&&PS!=PlayerState.Death){
			//GameOver();
			Application.LoadLevel ("Main");
		}
		if(other.gameObject.name=="DeathZone_1"&&PS!=PlayerState.Death){
			//GameOver();
			StartCoroutine(Die(0.01f));
			animation.Play("dying");
		}
		if (other.gameObject.tag == "up"||other.gameObject.tag=="circle") {
			Debug.Log (PS.ToString());
			StartCoroutine(Die(0.01f));
			animation.Play("dying");

		
			//Application.LoadLevel ("IntroScene");


			//GameOver();
		}
		if(other.gameObject.name=="bullDeath"){
			//GameOver();
			Application.LoadLevel ("IntroScene");
			DestroyObject(curbullet);

		}
	}
	IEnumerator Die(float waitTime){
		yield return new WaitForSeconds (1.0f);
		Application.LoadLevel ("Main");
	}
	void attack(){

		curbullet=Instantiate (bullet, new Vector3(10,1,0), Quaternion.identity)as GameObject ;

	}
}

