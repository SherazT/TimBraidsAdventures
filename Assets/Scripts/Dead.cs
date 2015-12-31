using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {


	
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Player")
		{

			Destroy(coll.gameObject);

		}
		if (coll.gameObject.name == "ball")
		{
			
			Destroy(coll.gameObject);
			
		}


	}









	
	
}