using UnityEngine;
using System.Collections;

public class Sync : MonoBehaviour {

	Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
	{
		Vector3 position = Vector3.zero;
		Vector3 velocity = Vector3.zero;
		float rotation = 0;

		if (stream.isWriting)
		{
			position = rb.position;
			velocity = rb.velocity;
			rotation = rb.rotation;
			stream.Serialize(ref position);
			stream.Serialize(ref velocity);
			stream.Serialize(ref rotation);
		}
		else
		{
			stream.Serialize(ref position);
			stream.Serialize(ref velocity);
			stream.Serialize(ref rotation);
			rb.position = position;
			rb.velocity = velocity;
			rb.rotation = rotation;
		}
		
	}
}
