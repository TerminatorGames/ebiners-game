using UnityEngine;
using System.Collections;

public class BallAttributes : MonoBehaviour {
	
	public float lifetime = 1f;
	
	float timeCount = 0f;

	void Update () {
		timeCount += Time.deltaTime;
		if(timeCount > lifetime)
		{
			GameObject.Destroy(this.gameObject);    
		}
	}
	void OnCollisionEnter(Collision collision) {

		GameObject.Destroy (this.gameObject);
	}
}