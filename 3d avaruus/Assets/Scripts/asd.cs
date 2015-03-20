using UnityEngine;
using System.Collections;

public class asd : MonoBehaviour {
	public float turnspeed = 50f;
	public float thrust = 5f;
	public float backthrust = 2f;
	public float maxvelocity = 10f;




	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame

	//movement, kaasua jos velocity < max, kääntymiset

	void Update () {

		print (GetComponent<Rigidbody> ().velocity.magnitude);

		if (Input.GetKey (KeyCode.W))
		{
			if (GetComponent<Rigidbody>().velocity.magnitude < maxvelocity)
			{
				GetComponent<Rigidbody> ().AddForce (transform.up * thrust);
			}
		}

		if (Input.GetKey (KeyCode.S))
		{
			if (GetComponent<Rigidbody>().velocity.magnitude < maxvelocity)
			{
				GetComponent<Rigidbody>().AddForce(-transform.up * backthrust);
			}
		}

		if (Input.GetKey (KeyCode.A))
			transform.Rotate(Vector3.forward, -turnspeed * Time.deltaTime);
		
		if (Input.GetKey (KeyCode.D))
			transform.Rotate(Vector3.forward, turnspeed * Time.deltaTime);
		
	}

}


