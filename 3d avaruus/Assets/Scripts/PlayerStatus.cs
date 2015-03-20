using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {
	public static float playershields;
	public static float playerhull;
	public static int ammocount;
	//public GameObject Player;

	//  tämä classi kaikkea playeriin liittyvää varten, shields, hull, aseet, ammot, fuel, jne....
	void Start () {
	//	Player = Resources.Load("Player") as GameObject;

		playershields = 100;
		playerhull = 100;
		ammocount = 300;
	}

	void Update () {

		if (playershields < 1) { 
			playerhull = (playerhull + playershields);
			playershields = 0;
		}

		if (playerhull < 1)
			Destroy (this.gameObject);

		//if(GameObject.FindGameObjectWithTag("Player") == null)
		//	GameObject Player = Instantiate (Player) as GameObject;
		//	playershields = 100;
		//	playerhull = 100;
		//	ammocount = 300;
	}
}

		
		
	

