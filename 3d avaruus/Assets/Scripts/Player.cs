using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float smooth = 2.0F;
	public float tiltAngle = 5.0F;
	public float pspeed = 5.0F;

	// Use this for initialization
	void Start () {
	
		transform.position = new Vector3 (1, 1, 1);

	}
	
	// Update is called once per frame
	void Update () {

		//updown
		transform.Translate (Vector3.up * Input.GetAxis ("Vertical") * pspeed * Time.deltaTime);

		//rotate
			float tiltAroundY = Input.GetAxis("Horizontal") * tiltAngle;
			transform.rotation = Quaternion.Euler(270, tiltAroundY, 0);

	}
}
