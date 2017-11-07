using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurunuru : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider stone){
		stone.material.dynamicFriction = 0.015f;
	}

	void OnTriggerExit(Collider stone){
		stone.material.dynamicFriction = 0.05f;
	}
}
