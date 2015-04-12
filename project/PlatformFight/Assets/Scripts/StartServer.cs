using UnityEngine;
using System.Collections;

public class StartServer : MonoBehaviour {

	public string gameName;
	public string roomName;
	// Use this for initialization
	public void InitServer () {
		Network.InitializeServer(4, 25000, !Network.HavePublicAddress());
		MasterServer.RegisterHost(gameName, roomName);
	}
	public static void somethin () {
		Debug.Log ("HI");
	}

	void OnServerInitialized () {
		Debug.Log("A game of " + gameName + " has started named " + roomName); 
	}
}
