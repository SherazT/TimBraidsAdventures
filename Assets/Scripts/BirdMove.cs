using UnityEngine;
using System.Collections;

public class BirdMove : MonoBehaviour
{
	
	private int speed = 5;
	private bool front;
	private bool back;

	Animator animator;

	// Use this for initialization
	void Start ()
	{
		front = true;
		back = false;
		animator.SetBool("dead",false);
	}
	
	// Update is called once per frame
	void Update ()
	{

		
		if (front) {
			
			transform.Translate (Vector2.left * speed * Time.deltaTime);


			if (transform.position.x <= 64){
			transform.Translate (Vector2.down * 0.5f *Time.deltaTime);
			}
			if (transform.position.x >= 64){
				transform.Translate (Vector2.up * 0.5f * Time.deltaTime);
			}



			//change direction so bird points front
			transform.rotation = Quaternion.Euler (transform.rotation.x, 180, transform.rotation.z);
		

			if (transform.position.x >= 76) {
				
				front = false;
				back = true;
				
			}
		}
		
		if (back) {

			transform.Translate (Vector2.left * speed * Time.deltaTime);

			transform.rotation = Quaternion.Euler (transform.rotation.x, 0, transform.rotation.z);

			if (transform.position.x <= 52) {
				back = false;
				front = true;
			}
		}


	}
	

	
	
	
	
	
	
	
	
	
}
