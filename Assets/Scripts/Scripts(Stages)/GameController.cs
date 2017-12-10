using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public StoneMover stone;
    public GoalController goalController;
    public Text clearText;
	public PlayerController playerController;
	
	void Start () {
        clearText.text = "";
	}
	
	void Update () {
		if (stone.Getvelocity ().Equals (Vector3.zero) 
			&& goalController.GetclearCheck () == 0 
			&& playerController.Getlaunch () == false) {
			clearText.text = "Failure!!";
		}

		if (stone.Getvelocity().Equals(Vector3.zero) 
			&& goalController.GetclearCheck() == 1){
            clearText.text = "Clear!!";
        }

        if (goalController.GetclearCheck() == 2){
            clearText.text = "Failure!!";
        }
	}
}
