using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStatReport: MonoBehaviour {
	private int shields;
	private int hull;
	private int ammo;
	private string weaponreport;
	
	Text text;
	
	void Start () {
		text = GetComponent <Text> ();
	}

	// alaboksiin reporttaa current shield, armor, weapon

	void Update () {
		shields = Mathf.RoundToInt (PlayerStatus.playershields);
		hull = Mathf.RoundToInt (PlayerStatus.playerhull);
		ammo = PlayerStatus.ammocount;
		weaponreport = PlayerStatus.weaponselected;

		text.text = "Shield status: " + shields +"%\nHull integrity: " + hull + "%\n\n" +weaponreport+": " +ammo;
	}
}
