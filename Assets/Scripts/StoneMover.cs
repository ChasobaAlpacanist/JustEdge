using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMover : MonoBehaviour {

	Rigidbody r;
    public SliderController slider;

	bool touch;
	public int coSpeed;

	// Use this for initialization
	void Start () 
	{
		r = GetComponent<Rigidbody> ();
		touch = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton("Vertical") && touch)
		{
			r.velocity = new Vector3 (0, 0, slider.SetSpeed() * coSpeed);
			touch = false;
		}
	}
}
