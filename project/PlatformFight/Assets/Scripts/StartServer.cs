using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartServer : MonoBehaviour {

	public string gameName;
	public string roomname;
	// Use this for initialization
	public void InitServer () {
		roomname = GameObject.FindGameObjectWithTag ("RoomName").GetComponent<InputField> ().textComponent.text;
		if (!roomname.Equals ("")) {
			Network.InitializeServer(4, 25000, !Network.HavePublicAddress());
			MasterServer.RegisterHost (gameName, roomname);
		}
		else {
			GameObject.FindGameObjectWithTag ("RoomName").GetComponent<InputField> ().placeholder.GetComponent<Text>().text = "Plz Give Room Name";
		}
	}
	public static void somethin () {
		Debug.Log ("HI");
	}

	void OnServerInitialized () {
		Debug.Log("A game of " + gameName + " has started named " + roomname);
		Application.LoadLevel (1);
	}
}
