using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetServers : MonoBehaviour {
	public HostData[] hosts;
	public GameObject button;
	public Transform hostFrame;
	private string gamename;

	void Start () {
		hostFrame = GameObject.FindGameObjectWithTag ("Hosts").transform;
	}

	public void getHosts()
	{
		foreach (Transform c in hostFrame) {
			GameObject.Destroy(c.gameObject);
		}

		gamename = GameObject.FindGameObjectWithTag ("StartServer").GetComponent<StartServer> ().gameName;
		MasterServer.RequestHostList(gamename);
	}
	
	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		if (msEvent == MasterServerEvent.HostListReceived) {
			hosts = MasterServer.PollHostList ();
			populateList();
		}
	}

	void populateList() {
		for (int i = 0; i < hosts.Length; i++) {
			GameObject g = (GameObject) Instantiate(button);
			g.GetComponent<ServerInfo>().data = hosts[i];
			g.transform.GetChild(0).GetComponent<Text>().text = hosts[i].gameName + " Players: " + hosts[i].connectedPlayers + "/" + hosts[i].playerLimit;
			g.transform.SetParent(hostFrame);
		}
	}
}
