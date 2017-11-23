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

        if (Input.GetMouseButtonDown(0) && launch == false && nuruLife.GetLife() > 0) {
			SmoothGround ();
			nuruLife.Lifereduce ();
        }
	}

	void SmoothGround(){
		Instantiate (smoothGround,
			position,
			Quaternion.identity);
	}
}
