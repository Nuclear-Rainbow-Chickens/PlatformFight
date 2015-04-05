using UnityEngine;
using System.Collections;

public class ResetAttack : MonoBehaviour {
	Animator anim;
	GameObject idlearm;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		idlearm = transform.parent.GetChild (0).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("idle")) {
			idlearm.SetActive(true);
			gameObject.SetActive(false);
			Debug.Log ("melee attack");
		}
	}
}
