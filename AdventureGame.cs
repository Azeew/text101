using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    [SerializeField] State currentState;

	void Start () {
        currentState = startingState;
        textComponent.text = currentState.storyText;
        Debug.Log(currentState.nextStates[0]);
    }
	
	void Update () {
        ManageStates();

    }

    private void ManageStates()
    {        
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            currentState = currentState.nextStates[0];
        }
    }



}
