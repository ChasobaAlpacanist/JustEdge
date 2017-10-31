using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMover : MonoBehaviour {

	Rigidbody r;

	bool touch;
	float initialVelocity;

	// Use this for initialization
	void Start () 
	{
		r = GetComponent<Rigidbody> ();
		touch = true;
		initialVelocity = 15;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton("Vertical") && touch)
		{
			r.velocity = new Vector3 (0, 0, initialVelocity);
			touch = false;
		}
	}
}
