using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TapController : MonoBehaviour {

	/*public delegate void PlayerDelegate();
	public static event PlayerDelegate OnPlayerDied;
	public static event PlayerDelegate OnPlayerScored;*/
	GameControl gameControl;
	
	public bool isDead = false;
	public float tapForce = 10;
	public float tiltSmooth = 5;
	public Vector3 startPos;
	bool isMoving;
	//public Animator playerDeath;


	Rigidbody2D rigidBody;
	Quaternion downRotation;
	Quaternion forwardRotation;

	
	

	void Start() {
		
		Time.timeScale = 0;
		isMoving = true;
		rigidBody = GetComponent<Rigidbody2D>();
		downRotation = Quaternion.Euler(0, 0 ,-30);
		forwardRotation = Quaternion.Euler(0, 0, 50);
		gameControl = GetComponent<GameControl>();
		
		//trail = GetComponent<TrailRenderer>();
		//trail.sortingOrder = 20; 
	}

	/*void OnEnable() {
		GameManager.OnGameStarted += OnGameStarted;
		GameManager.OnGameOverConfirmed += OnGameOverConfirmed;
	}

	void OnDisable() {
		GameManager.OnGameStarted -= OnGameStarted;
		GameManager.OnGameOverConfirmed -= OnGameOverConfirmed;
	}

	void OnGameStarted() {
		rigidBody.velocity = Vector3.zero;
		rigidBody.simulated = true;
	}

	void OnGameOverConfirmed() {
		transform.localPosition = startPos;
		transform.rotation = Quaternion.identity;
	}*/

	void Update() {

		if (isMoving == true)
		{
			if (Input.GetMouseButtonDown(0))
			{
				Time.timeScale = 1;
				rigidBody.velocity = Vector2.zero;
				transform.rotation = forwardRotation;
				rigidBody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);

			}

			transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);
		}
		
	
	}
	IEnumerator ExampleCoroutine()
	{
		yield return new WaitForSeconds(2);
		
		GameControl.instance.BirdDied();
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "ScoreZone") {
			GameControl.instance.BirdScored();
			GameControl.instance.scalePlusScore();
		
		}
		if (col.gameObject.tag == "Coin") {
			Destroy(col.gameObject) ;
			
			GameControl.instance.BirdCoins();
			


		}
		if (col.gameObject.tag == "DeadZone"&&col.gameObject.GetComponent<CircleCollider2D>()!=null)
		{
			isMoving = false;
			StartCoroutine(ExampleCoroutine());
			col.GetComponent<CircleCollider2D>().isTrigger = false;

			//rigidBody.simulated = false;
		}
		 if (col.gameObject.tag=="DeadZone"&& col.gameObject.GetComponent<BoxCollider2D>() != null)
		{
			isMoving = false;
			StartCoroutine(ExampleCoroutine());
			col.GetComponent<BoxCollider2D>().isTrigger = false;
			GetComponent<Animator>().Play("PlayerDeath");
		}
		

			//OnPlayerDied();
	}
	private void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "ScoreZone")
		{
			//GameControl.instance.scaleMinusScore();
		}
	}

}
