using UnityEngine;
using System.Collections;

public class CoinCollide : MonoBehaviour {

	private Collision2D fly;
	private Collision2D fly1;
	public static bool BirdDead; 


	Animator animator;


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Coin") {
			fly = coll;
		
		}
		if (coll.gameObject.name == "Bird") {
			//coll2 = coll;
			BirdDead = true;

			//Destroy(coll.gameObject);

		}
	}


	void Update (){

		//make coins fly up


		fly.gameObject.transform.Translate (Vector2.up * 45 * Time.deltaTime);


	}




}