using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public StoneMover stone;
	public NurunuruController nuruLife;
    bool launch;

	private Vector3 position;

	public GameObject smoothGround;
	void Start () {
        launch = true;
	}

	void Update () {
		position = stone.transform.position;
		position.z += 10;

		if (Input.GetButton("Vertical") && launch) {
            launch = false;
            stone.Launch(); 
        }

        /*if (Input.GetMouseButtonDown(0)) {
			SmoothGround ();
        }*/
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
