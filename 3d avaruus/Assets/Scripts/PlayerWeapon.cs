using UnityEngine;
using System.Collections;

public class PlayerWeapon : MonoBehaviour {
	public GameObject Ball;
	private Vector3 suunta;
	private Vector3 asuunta;
	public float fireRate = 0.1F;
	public float projectileSpeed = 80f;
	private float nextFire = 0.0F;
	//private float vauhti;

	void Start () {
		Ball = Resources.Load ("Ball") as GameObject;
		}

		void Update() {

		suunta = MouseTracking.mrelative;
		asuunta = transform.position;


		//printtaa consoliin hiiren koordinaatit pelialueella, vaatii säätöä
		print (suunta - asuunta);

		if (Input.GetKey (KeyCode.Mouse0) && Time.time > nextFire){
			nextFire = Time.time + fireRate;

			GameObject projectile = Instantiate (Ball) as GameObject;
			projectile.transform.position = (transform.position + (Vector3.Normalize(suunta - asuunta)*2));

			Rigidbody rb = projectile.GetComponent<Rigidbody> ();

			//vauhti = PlayerMovement.kulli.velocity.magnitude;
			rb.AddForce(Vector3.Normalize(suunta - asuunta) * projectileSpeed, ForceMode.VelocityChange);


		}
		}
	}