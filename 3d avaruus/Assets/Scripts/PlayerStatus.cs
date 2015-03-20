using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {
	public static float playershields;
	public static float playerhull;

	//  tämä classi kaikkea playeriin liittyvää varten, shields, hull, aseet, ammot, fuel, jne....
	void Start () {
		playershields = 100;
		playerhull = 100;
	}

	void Update () {
	
	}
}
