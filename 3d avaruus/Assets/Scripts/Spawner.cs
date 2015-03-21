using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject Player;
	private Quaternion quat;
	private Vector3 trans;

	void Start () {
		Player = Resources.Load("Player") as GameObject;
		quat = Player.transform.rotation;
		trans = Player.transform.position;
	}
	

	void Update () { //jos pelaaja kuolee, spawnaa pelaajan uusiks

		if(GameObject.FindGameObjectWithTag("Player") == null)
		Player = Instantiate (Player, trans, quat) as GameObject;
		Player = Resources.Load("Player") as GameObject;
	}
}
