using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	GameObject meleeObj;
	GameObject rangedObj;

	public short playerNumber;
	// Use this for initialization
	void Start () {
		meleeObj = transform.parent.GetChild (2).gameObject;
		rangedObj = transform.parent.GetChild (1).gameObject;
		playerNumber = short.Parse (LayerMask.LayerToName (short.Parse (gameObject.layer.ToString ())));
	}
	
	// Update is called once per frame
	void Update () {
		if(InputC.melee(playerNumber)) {
			meleeObj.SetActive(true);
			gameObject.SetActive(false);
		}
		if(InputC.ranged(playerNumber)) {
			rangedObj.SetActive(true);
			gameObject.SetActive(false);
		}
	}
}
