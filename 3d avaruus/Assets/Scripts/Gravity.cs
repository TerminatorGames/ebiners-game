﻿using UnityEngine;
using System.Collections.Generic;

public class Gravity : MonoBehaviour 
{	
	public float range = 500;


	//planeettojen ja muiden isojen objektien vetovoima, älä koske :D
	void FixedUpdate () 
	{
		Collider[] cols  = Physics.OverlapSphere(transform.position, range); 
		List<Rigidbody> rbs = new List<Rigidbody>();
		
		foreach(Collider c in cols)
		{
			Rigidbody rb = c.attachedRigidbody;
			if(rb != null && rb != GetComponent<Rigidbody>() && !rbs.Contains(rb))
			{
				rbs.Add(rb);
				Vector3 offset = transform.position - c.transform.position;
				rb.AddForce( offset / offset.sqrMagnitude * GetComponent<Rigidbody>().mass);
			}
		}
	}
}