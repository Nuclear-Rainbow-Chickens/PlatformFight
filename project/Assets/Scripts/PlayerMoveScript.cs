using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {

    public float speed;
    public float jumpHeight;
    public bool grounded = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        InputMovement();
	}

    void InputMovement()
    {
        rigidbody2D.AddForce(new Vector2(Input.GetAxis("Horizontal"), 0) * speed);
        if (rigidbody2D.velocity.x < -0.5)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKey(KeyCode.UpArrow) && grounded)
        {
            rigidbody2D.AddForce(Vector2.up * jumpHeight);
            grounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        bool onTop = false;
        float top = c.collider.bounds.extents.y + c.collider.gameObject.transform.position.y;
        float bottom = transform.position.y - collider.bounds.extents.y;
        if (c.collider.tag.Equals("ground"))
        {
            grounded = true;
        }
    }
}
