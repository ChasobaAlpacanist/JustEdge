using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public StoneMover stone;
    public GoalController GoalController;
    public Text clearText;
	
	void Start () {
        clearText.text = "";
	}
	
	void Update () {
        if (stone.Getvelocity().Equals(Vector3.zero) && GoalController.GetclearCheck() == 1){
            clearText.text = "Clear!!";
        }

        if (GoalController.GetclearCheck() == 2){
            clearText.text = "Failure!!";
        }
	}
}
