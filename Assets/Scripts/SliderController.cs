using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {

	public int speed;
	public float degree;

	Slider power;

	// Use this for initialization
	void Start () {
		power = GetComponent<Slider> ();
		degree = 0;
	}
	
	// Update is called once per frame
	void Update () {
		degree += speed * Time.deltaTime;
	}

	void LateUpdate(){
		power.value = 0.5f + 0.5f * Mathf.Sin (degree * Mathf.Deg2Rad);
	}
}
