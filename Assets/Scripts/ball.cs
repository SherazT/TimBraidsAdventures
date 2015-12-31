using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Player")
		{

			_startMoving();


		}
	}

	void _startMoving(){
		int i = 0;
		while(i<100){
		transform.rotation = Quaternion.Euler (transform.rotation.x , transform.rotation.y, transform.rotation.z-40);
			i++;
		}
		}
}
