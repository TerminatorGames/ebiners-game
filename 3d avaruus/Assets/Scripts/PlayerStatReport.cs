using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStatReport: MonoBehaviour {
	private string weaponselected = "Pulse Laser";
	private int shields;
	private int hull;
	
	Text text;
	
	void Start () {
		text = GetComponent <Text> ();
	}

	// alaboksiin reporttaa current shield, armor, weapon

	void Update () {
		shields = Mathf.RoundToInt (PlayerStatus.playershields);
		hull = Mathf.RoundToInt (PlayerStatus.playerhull);
		text.text = "Shield status: " + shields +"%\nHull integrity: " + hull + "%\n\n" +weaponselected;
	}
}
