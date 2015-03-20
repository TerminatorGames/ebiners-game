using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStatReport: MonoBehaviour {
	private string weaponselected = "Machine gun";
	private int shields;
	private int hull;
	private int ammo;
	
	Text text;
	
	void Start () {
		text = GetComponent <Text> ();
	}

	// alaboksiin reporttaa current shield, armor, weapon

	void Update () {
		shields = Mathf.RoundToInt (PlayerStatus.playershields);
		hull = Mathf.RoundToInt (PlayerStatus.playerhull);
		ammo = PlayerStatus.ammocount;

		text.text = "Shield status: " + shields +"%\nHull integrity: " + hull + "%\n\n" +weaponselected+": " +ammo;
	}
}
