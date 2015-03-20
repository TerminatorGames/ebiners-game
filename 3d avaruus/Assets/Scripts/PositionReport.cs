using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PositionReport : MonoBehaviour {
	private Vector3 playerpos;
	private float playervelocity;
	private string ptext;
	private string ptext2;
	Text text;

	void Start () {
		text = GetComponent <Text> ();
	}

	void Update () {
		playerpos = GameObject.FindWithTag ("Player").transform.position;
		playervelocity = GameObject.FindWithTag ("Player").GetComponent<Rigidbody> ().velocity.magnitude;
		ptext = playerpos.ToString ();
		ptext2 = playervelocity.ToString ();
		text.text = ptext + " " + ptext2;
	}
}
