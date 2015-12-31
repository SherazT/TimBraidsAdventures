using System;
using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour
{

	//declare variables
	public float speed = 1.5f;
	public int addspeed = 2;
	private bool dead1;
	public Transform Plank;
	private int speed1 = 100;



	Animator animator;
	
	void Start ()
	{

		//initialization of variables
		dead1 = false;
		animator = GetComponent<Animator>();
		AudioSource audio = gameObject.AddComponent < AudioSource > ();
		

		



	}

	
	void Update ()
	{
		//set booleans to false
		animator.SetBool ("left", false);
		animator.SetBool ("right", false);
		animator.SetBool ("jump", false);

		//GetComponent<AudioSource>().Pause();

		//============================================RUN=======================================================
		//run left
		if (Input.GetKey (KeyCode.LeftArrow)){
			transform.position += Vector3.left * speed * Time.deltaTime * addspeed;

			//change direction of player towards arrow key
			transform.rotation = Quaternion.Euler (transform.rotation.x, 180, transform.rotation.z);

			//set animator transition to true 
			animator.SetBool ("left", true);
			GetComponent<AudioSource>().Play();
			//play walking sound
			GetComponent<AudioSource>().UnPause();

		}
		GetComponent<AudioSource>().Pause();
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += Vector3.right * speed * Time.deltaTime * addspeed;

			//change direction of player towards arrow key
			transform.rotation = Quaternion.Euler (transform.rotation.x, 0, transform.rotation.z);

			//set animator transition to true 
			animator.SetBool ("right", true);

			GetComponent<AudioSource>().Play();
			//play walking sound
			GetComponent<AudioSource>().UnPause();
		}
		GetComponent<AudioSource>().Pause();
		//==================================JUMP=================================================

		if (Input.GetKey (KeyCode.Space)) {
			transform.position = new Vector3 (transform.position.x, transform.position.y + 3.5f * (Time.deltaTime), 0);
			animator.SetBool ("jump", true);


		}


		//Falling to death
		if ((transform.position.x > 20) && (transform.position.x < 41) && (transform.position.y < 1)){

			animator.SetBool ("dead", true);
			Application.Quit();
		}



	}

	//move with moving platform
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Plank") {
			this.transform.parent = Plank.transform;
		}
		else if (!(coll.gameObject.name == "Plank")) {
			this.transform.parent = Plank.transform;
			transform.parent = null;
		}

		//exit game
		if (coll.gameObject.name == "exit") {
			Application.Quit();

		}

	}

	//==========================KICK BALL================================


		
		
	void  OnControllerColliderHit ( Collision2D hit){
			if(hit.gameObject.name == "ball"){
				Debug.Log("We hit a object");
				hit.rigidbody.AddForce(Vector3.forward * 100000000000);
			}
		}
	}








	
		//===================================================DYING====================
	/*
		void OnCollisionEnter2D(Collision2D coll)
		{
			if (coll.gameObject.name == "trigger1")
			{
				dead1 = true;
			Debug.Log("HIT");
			}
		}






*/



		/*

		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
		
		*/
	
