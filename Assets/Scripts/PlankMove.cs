using UnityEngine;
using System.Collections;

public class PlankMove : MonoBehaviour
{

	private int speed = 5;
	private bool front;
	private bool back;

	// Use this for initialization
	void Start ()
	{
		front = true;
		back = false;
	}
		
	// Update is called once per frame
	void Update ()
	{


		if (front) {

			transform.Translate (Vector2.right * speed * Time.deltaTime);
			if (transform.position.x >= 39) {

				front = false;
				back = true;

			}
		}

		if (back) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
			if (transform.position.x <= 25) {
				back = false;
				front = true;
			}
		}


	}













}
