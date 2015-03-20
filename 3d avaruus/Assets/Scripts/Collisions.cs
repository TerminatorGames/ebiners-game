using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour {

	private Vector3 spawn;

	// Use this for initialization
	void Start () {
		spawn = GetComponent<Transform>().position;
	}

	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "Planet") {
			transform.position = spawn;
		}
	}
}

