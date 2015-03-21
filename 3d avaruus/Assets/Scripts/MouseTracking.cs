using UnityEngine;
using System.Collections;

public class MouseTracking : MonoBehaviour {
	private Vector3 mousepos;
	public static Vector3 mrelative;
	public float xoffset = 0;
	public float zoffset = -17f;

	void Start () {
	}

	void Update () {

		// trackaa hiiren x/y koordinaatteja ja muuttaa ne world koordinaateiksi
		mousepos = Input.mousePosition;
		mousepos = Camera.main.ScreenToWorldPoint (mousepos);
		mousepos.y = 0;
		mrelative = (mousepos + new Vector3 (xoffset, 0, zoffset));

	}
}
