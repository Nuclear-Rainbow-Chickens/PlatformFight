using UnityEngine;
using System.Collections;

public class SpawnPlayer : MonoBehaviour {

	public GameObject player;

	void Start ()
	{
		if (Network.isClient) {
			Network.Instantiate (player, Vector3.zero, Quaternion.identity, 0);
		}
	}
}
