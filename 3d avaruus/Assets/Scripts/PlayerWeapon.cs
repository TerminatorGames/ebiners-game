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
		
		suunta = (MouseTracking.mrelative);
		asuunta = transform.position;
		
		
		//printtaa consoliin hiiren koordinaatit pelialueella, vaatii säätöä
		//print (suunta - asuunta); //debuggausta

		    Debug.DrawLine(transform.position, (Vector3.Normalize(suunta - asuunta))*1000, Color.green); //debuggausta

		if (PlayerStatus.ammocount > 0){
		if (Input.GetKey (KeyCode.Mouse0) && Time.time > nextFire){ // rof
		
			nextFire = Time.time + fireRate;

			PlayerStatus.ammocount--; // ammo

			GameObject projectile = Instantiate (Ball) as GameObject;
			projectile.transform.position = (transform.position + (Vector3.Normalize(suunta - asuunta)*2)); //ampuminen hiiren suuntaan
			
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			
			//vauhti = PlayerMovement.kulli.velocity.magnitude;
			rb.AddForce(Vector3.Normalize(suunta - asuunta) * projectileSpeed, ForceMode.VelocityChange);
			}
			
		}
	}
}