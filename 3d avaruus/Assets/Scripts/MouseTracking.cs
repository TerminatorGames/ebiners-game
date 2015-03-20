using UnityEngine;
using System.Collections;

public class MouseTracking : MonoBehaviour {
	private Vector3 mousepos;
	public static Vector3 mrelative; 

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {

		mousepos = Input.mousePosition;
		mousepos = Camera.main.ScreenToWorldPoint (mousepos);
		mousepos.y = 0;
		mrelative = mousepos;

	}
}
