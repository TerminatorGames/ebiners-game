using UnityEngine;
using System.Collections;

public class PUNnetworkManager : MonoBehaviour {
	public string playerPrefabName = "Player";
	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings ("0.1");
	}

	void OnJoinedLobby() {
		RoomOptions roomOptions = new RoomOptions () {
			isVisible = false, maxPlayers = 20 };
		PhotonNetwork.JoinOrCreateRoom ("pedik", roomOptions, TypedLobby.Default);

	}

	void OnJoinedRoom() {
		GameObject player = PhotonNetwork.Instantiate (playerPrefabName, spawnPoint.position, spawnPoint.rotation, 0);
		PlayerMovement movement = player.GetComponent<PlayerMovement>();
		movement.enabled = true;
		PlayerWeapon weapon = player.GetComponent<PlayerWeapon>();
		weapon.enabled = true;
		PlayerStatus status = player.GetComponent<PlayerStatus>();
		status.enabled = true;
		MouseTracking tracking = player.GetComponent<MouseTracking>();
		tracking.enabled = true;
	}

}
