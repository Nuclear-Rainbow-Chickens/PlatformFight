using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public float speed;
	public float jumpHeight;
	public bool canJump;
	public short playerNumber;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		playerNumber = short.Parse (LayerMask.LayerToName(short.Parse(gameObject.layer.ToString ())));
		Debug.Log (playerNumber);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		InputMovement ();
	}

	void InputMovement() {
		rb.velocity = new Vector2 (InputC.getHorz(playerNumber) * speed, rb.velocity.y);
		if (InputC.getHorz(playerNumber) < 0) {
			transform.localScale = new Vector3 (-1, transform.localScale.y, 1);
		} 
		else if (InputC.getHorz(playerNumber) > 0) {
			transform.localScale = new Vector3 (1, transform.localScale.y, 1);
		}
		if (InputC.jump(playerNumber) && canJump) {
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
