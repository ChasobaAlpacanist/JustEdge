using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {

	public int speed;

	Slider power;
    bool changeSpeed;
    float degree;

    // Use this for initialization
    void Start () {
		power = GetComponent<Slider> ();
		degree = 0;
		changeSpeed = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (changeSpeed) {
			degree += speed * Time.deltaTime;
		}
	}

	void LateUpdate(){
		power.value = 0.5f + 0.5f * Mathf.Sin (degree * Mathf.Deg2Rad);
	}

    public float SetSpeed() {
        changeSpeed = false;
        return power.value;
    }
}
