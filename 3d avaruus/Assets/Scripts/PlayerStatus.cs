using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {
	public static float playershields;
	public static float playerhull;
	public static int ammocount;
	public static string weaponselected = "Autocannon";


	//  tämä classi kaikkea playeriin liittyvää varten, shields, hull, aseet, ammot, fuel, jne....
	void Start () {
		playershields = 100; //respawnissa kaikki täyteen
		playerhull = 100;
		ammocount = 2000;
	}

	void FixedUpdate () {

	// jos shieldit <1, damage applytään hulliin, jos hull <1, alus tuhoutuu
		if (playershields < 1) { 
			playerhull = (playerhull + playershields);
			playershields = 0;
		}

		if (playerhull < 1)
			Destroy (this.gameObject);
	}
}

		
		
	

