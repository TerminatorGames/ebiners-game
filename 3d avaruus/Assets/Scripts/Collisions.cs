using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour {

	private Vector3 spawn;
	public static string lastcollision;


	// Use this for initialization
	void Start () {
		// spawn = GetComponent<Transform>().position;
	}

	// collisionissa tapahtuva eventti, tällä hetkellä damagea + viesti
	void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "Planet") {
			PlayerStatus.playershields = PlayerStatus.playershields - 300;
			lastcollision = "Player met harsh reality that high-speed scissors cant beat solid rock.";
		}

		if (collision.transform.tag == "Sun") {
			PlayerStatus.playershields = PlayerStatus.playershields - 300;
			lastcollision = "Player wanted to take a deeper look into how fusion reactions work.";
		}
	}
}

