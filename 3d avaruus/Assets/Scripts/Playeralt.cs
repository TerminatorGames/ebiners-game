using UnityEngine;
using System.Collections;

public class Playeralt : MonoBehaviour {
	public float mspeed = 10F;
	public float turnspeed = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W))
			transform.Translate(Vector3.forward * mspeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.A))
			transform.Rotate(Vector3.up, -turnspeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.D))
			transform.Rotate(Vector3.up, turnspeed * Time.deltaTime);
	
	}
}
