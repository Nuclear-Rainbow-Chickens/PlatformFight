using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	GameObject meleeObj;
	GameObject rangedObj;
	// Use this for initialization
	void Start () {
		meleeObj = transform.parent.GetChild (2).gameObject;
		rangedObj = transform.parent.GetChild (1).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(InputC.melee()) {
			meleeObj.SetActive(true);
			gameObject.SetActive(false);
		}
		if(InputC.ranged()) {
			rangedObj.SetActive(true);
			gameObject.SetActive(false);
		}
	}
}
