using UnityEngine;
using System.Collections;

public class GravityOscillator : MonoBehaviour {
	private Rigidbody2D rb;
	private bool antiGravity = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (rb.velocity.y < -5) 
		{
			antiGravity = true;
		}
		if (rb.velocity.y > 5) 
		{
			antiGravity = false;
		}

		rb.gravityScale = (float)((antiGravity) ? -1 : 1);
	}
}
