using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public StoneController stone;
	public NurunuruController nuruLife;
	public SliderController slider;
    
	bool launch;
	public bool Getlaunch() {
		return launch;
	}

	private Vector3 position;

	public GameObject smoothGround;
	void Start () {
        launch = true;
	}

	void Update () {
		position = stone.transform.position;
		position.z += 10;

		if (Input.GetButton("Vertical") && launch) {
			stone.SetVelocity (slider.SetSpeed());
			launch = false;

        }
	}

	public void SmoothGround(){
		if (launch == false && nuruLife.GetLife () > 0) {
			Instantiate (smoothGround,
				position,
				Quaternion.identity);
			nuruLife.Lifereduce ();
		}
	}
}
