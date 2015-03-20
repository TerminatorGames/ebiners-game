using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EventReport: MonoBehaviour {
	private string teksti;	
	Text text;
	
	void Start () {
		text = GetComponent <Text> ();
	}

	//reporttaa tällä hetkellä collisionit textboksiin
	
	void Update () {
		teksti = Collisions.lastcollision;
		text.text = teksti;
	}
}
