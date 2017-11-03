using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public StoneMover stone;
    bool launch;

    //Mouse`s position
    private Vector3 position;
    private Vector3 worldPositionofMouse;

    public float zPosi;

    public GameObject UNK;

	void Start () {
        launch = true;
	}
	
	void Update () {
        if (Input.GetButton("Vertical") && launch) {
            launch = false;
            stone.Launch(); 
        }

        if (Input.GetMouseButtonDown(0)) {
            GetMousePosition();
        }
	}

    //Make pointed ground smoother (now Instanciates UNK)
    void GetMousePosition() {
        position = Input.mousePosition;
            
        //adjust z position
        position.z = zPosi;
        worldPositionofMouse = Camera.main.ScreenToWorldPoint(position);

        Instantiate(UNK,
            worldPositionofMouse,
            Quaternion.identity);
           
    }
}
