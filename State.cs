using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject {

    [TextArea(10,14)][SerializeField] public string storyText;
    [SerializeField] public State[] nextStates;
 

}
