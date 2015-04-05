using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	private HostData[] hostList;
	private const string typeName = "NextGameXD";
	private const string gameName = "RoomName";
	private MasterServerEvent msEvent;

	void LaunchServer() {
		bool useNat = !Network.HavePublicAddress();
		Network.InitializeServer(32, 25000, useNat);
		MasterServer.RegisterHost(typeName,gameName);
	}

	void OnServerInitialized(){
		Debug.Log("Server Initializied");
	}

	
	private void RefreshHostList()
	{
		MasterServer.RequestHostList (typeName);
	    Debug.Log (MasterServer.PollHostList ().Length);
	}
	
	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		if (msEvent == MasterServerEvent.HostListReceived)
			hostList = MasterServer.PollHostList();
	}

	void OnConnectedToServer()
	{
		Debug.Log("Server Joined");
	}
	
	void OnMasterServerEvent()
	{
		if (msEvent == MasterServerEvent.HostListReceived)
			hostList = MasterServer.PollHostList();
	}

	private void JoinServer(HostData hostData)
	{
		Network.Connect(hostData);
	}
		
	void Update(){
	if (!Network.isClient && !Network.isServer)
	{
		if (Input.GetKey(KeyCode.U)) 
			LaunchServer();
	}
	if (Input.GetKey(KeyCode.I))
			RefreshHostList();
	}
void OnGUI(){
		if (hostList != null)
	for (int i = 0; i < hostList.Length; i++)
	{
			if (GUI.Button(new Rect(400, 100 + (110 * i), 300, 100), hostList[i].gameName))
				JoinServer(hostList[i]);
		}
	}	
}