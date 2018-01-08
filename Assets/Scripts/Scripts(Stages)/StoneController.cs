using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour {

	Rigidbody r;
    public SliderController slider;
	public AudioSource deathSound;

	public int coSpeed;

	void Start () {
		r = GetComponent<Rigidbody> ();
	}
	
	public void SetVelocity(float zspeed) {
		r.velocity = new Vector3 (0, 0, zspeed * coSpeed);
	}
		
	public void DeathVoice() {
		deathSound.Play ();
	}

	public Vector3 Getvelocity() {
        return r.velocity;
    }
}
