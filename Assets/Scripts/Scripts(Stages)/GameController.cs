using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public StoneController stone;
    public GoalController goalController;
    public Text clearText;
	public PlayerController playerController;

	bool playable;
	
	void Start () {
        clearText.text = "";
		playable = true;
	}
	
	void LateUpdate () {
		if (stone.Getvelocity ().Equals (Vector3.zero) 
			&& goalController.GetclearCheck () == 0 
			&& playerController.Getlaunch () == false) {
			clearText.text = "Too Slow!!";
		}

		if (stone.Getvelocity().Equals(Vector3.zero) 
			&& goalController.GetclearCheck() == 1){
            clearText.text = "Clear!!";
        }

        if (goalController.GetclearCheck() == 2){
            clearText.text = "Too Fast!!";
			if(playable) {
				stone.DeathVoice ();
				playable = false;
			}
        }
	}
}
