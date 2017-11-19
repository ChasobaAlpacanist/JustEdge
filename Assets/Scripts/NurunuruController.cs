using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NurunuruController : MonoBehaviour {

	public GameObject[] icons;

	private int life = 3;

	public void Lifereduce(){
		life--;
	}

	public int GetLife() {
		return life;
	}

	void Update(){
		for (int i = 0; i < 3; i++) {
			if (life > i) {
				icons [i].SetActive (true);
			} else {
				icons [i].SetActive (false);
			}
		}
	}	
}
