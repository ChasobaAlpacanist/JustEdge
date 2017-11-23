using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {

    private int clearCheck;

    private void Start(){
        clearCheck = 0;
    }

    private void OnTriggerEnter(Collider other){
        clearCheck = 1;
    }

    private void OnTriggerExit(Collider other){
        clearCheck = 2;
    }

    public int GetclearCheck(){
        return clearCheck;
    }

}
