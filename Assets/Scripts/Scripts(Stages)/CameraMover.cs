using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

	public GameObject stone;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = GetComponent<Camera>().transform.position - stone.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 newPosition = GetComponent<Camera>().transform.position;
		newPosition.x = stone.transform.position.x + offset.x;
		newPosition.y = stone.transform.position.y + offset.y;
		newPosition.z = stone.transform.position.z + offset.z;
		GetComponent<Camera>().transform.position = Vector3.Lerp (GetComponent<Camera>().transform.position, 
			newPosition,
			5.0f * Time.deltaTime);
	}
}
