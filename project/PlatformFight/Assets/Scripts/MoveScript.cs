﻿using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public float speed;
	public float jumpHeight;
	public bool canJump;
	Rigidbody2D rb;
	NetworkView nv;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		nv = GetComponent<NetworkView> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//if (nv.isMine) {
			InputMovement ();
		//}
	}

	void InputMovement() {
		rb.velocity = new Vector2 (Input.GetAxis ("Horizontal") * speed, rb.velocity.y);
		if (Input.GetAxis ("Horizontal") < 0) {
			transform.localScale = new Vector3 (-1, transform.localScale.y, 1);
		} 
		else if (Input.GetAxis ("Horizontal") > 0) {
			transform.localScale = new Vector3 (1, transform.localScale.y, 1);
		}
		if (( Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) )&& canJump) {
			rb.velocity = new Vector2 (rb.velocity.x, jumpHeight);
			canJump = false;
		}
	}

	void OnCollisionStay2D(Collision2D c) {
		canJump = true;
	}

	void OnCollisionExit2D(Collision2D c) {
		canJump = false;
	}
}