using UnityEngine;
using System.Collections;

public class CAMERA : MonoBehaviour {
	
	public Transform target;
	public float smoothTime = 0.3f;
	public float xoffset = 1;
	public float zoffset = 1;
	public int camrangemax = 50;
	public int camrangemin = 10;
	
	private Vector3 velocity = Vector3.zero;
	
	void FixedUpdate () {

		target = GameObject.FindWithTag ("Player").transform;

		Vector3 goalPos = target.position;
		goalPos.y = transform.position.y;
		goalPos.x = target.position.x - xoffset;
		goalPos.z = target.position.z - zoffset;
		transform.position = Vector3.SmoothDamp (transform.position, goalPos, ref velocity, smoothTime);

		if (Input.GetAxis ("Mouse ScrollWheel") < 0) 
		{
			Camera.main.orthographicSize++;
		}
		if (Input.GetAxis("Mouse ScrollWheel") > 0) 
		{
			Camera.main.orthographicSize--;
		}
		
		Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, camrangemin, camrangemax);
	}
}
