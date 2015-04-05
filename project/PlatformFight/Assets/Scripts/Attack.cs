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
		if(Input.GetKeyDown(KeyCode.Z)) {
			meleeObj.SetActive(true);
			gameObject.SetActive(false);
		}
		if(Input.GetKeyDown(KeyCode.X)) {
			rangedObj.SetActive(true);
			gameObject.SetActive(false);
		}
	}
}
