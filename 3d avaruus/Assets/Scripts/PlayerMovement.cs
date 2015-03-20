using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float turnspeed = 50f;
	public float thrust = 5f;
	public float backthrust = 2f;
	public float maxvelocity = 10f;
	public float dragfactor = 1;
	public Rigidbody kulli;

	
	void Start () {
		kulli = GetComponent<Rigidbody> ();
	}
	
	//movement

	void FixedUpdate () {

		if (Input.GetKey (KeyCode.W))
		{
				kulli.AddForce (transform.up * thrust);
		}

		if (Input.GetKey (KeyCode.S))
		{
				kulli.AddForce(-transform.up * backthrust);
		}

		if (Input.GetKey (KeyCode.A))
			transform.Rotate(Vector3.forward, -turnspeed * Time.deltaTime);
		
		if (Input.GetKey (KeyCode.D))
			transform.Rotate(Vector3.forward, turnspeed * Time.deltaTime);


		//lisää dragia jos velocity yli maxvelocityn
		if (kulli.velocity.magnitude > maxvelocity)
			kulli.drag = (kulli.velocity.magnitude - maxvelocity) * dragfactor;

		if (kulli.velocity.magnitude < maxvelocity)
			kulli.drag = 0;
			
	}

}


