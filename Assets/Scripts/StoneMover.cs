using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMover : MonoBehaviour {

	Rigidbody r;
    public SliderController slider;

	bool touch;
	public int coSpeed;

	void Start () 
	{
		r = GetComponent<Rigidbody> ();
		touch = false;
	}
	
	void Update () 
	{
		if(touch)
		{
			r.velocity = new Vector3 (0, 0, slider.SetSpeed() * coSpeed);
			touch = false;
		}
	}
    
	public void Launch() {
        touch = true;
    }
}
