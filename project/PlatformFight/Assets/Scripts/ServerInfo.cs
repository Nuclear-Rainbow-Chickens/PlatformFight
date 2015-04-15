using UnityEngine;
using System.Collections;

public class ServerInfo : MonoBehaviour {

	public HostData data;

	public void join() {
		Network.Connect (data);
	}

	void OnConnectedToServer() {
		Application.LoadLevel (1);
	}
}
