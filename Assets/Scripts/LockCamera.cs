using UnityEngine;
using System.Collections;

public class LockCamera : MonoBehaviour {

	public Transform Player;

	void Update()
	{
		transform.position = new Vector3 (Player.position.x, Player.position.y, -10);


	}
}
