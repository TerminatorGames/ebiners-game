using UnityEngine;
using System.Collections;

public class asd : MonoBehaviour {
	public float turnspeed = 50f;
	public float thrust = 5f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.W))
			//vanha movement
			//transform.Translate(Vector3.up * mspeed * Time.deltaTime);
			GetComponent<Rigidbody>().AddForce(transform.up * thrust);
		
		if (Input.GetKey (KeyCode.A))
			transform.Rotate(Vector3.forward, -turnspeed * Time.deltaTime);
		
		if (Input.GetKey (KeyCode.D))
			transform.Rotate(Vector3.forward, turnspeed * Time.deltaTime);
		
	}
}


