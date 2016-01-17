using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayControllerStats : MonoBehaviour{
    private GameObject controllerTextBox;
    private GameObject leftTextBox;
    private GameObject rightTextBox;

	void Start () {
        controllerTextBox = GameObject.Find("Controller");
        leftTextBox = GameObject.Find("Text Left");
        rightTextBox = GameObject.Find("Text Right");
	}
	
	void Update () {
        var leftTriggers = "leftStickHorizontal = " + Controller.leftStickHorizontal + "\n";
        leftTriggers += "leftStickVertical = " + Controller.leftStickVertical +  "\n";
        leftTriggers += "rightStickHorizontal = " + Controller.rightStickHorizontal +  "\n";
        leftTriggers += "rightStickVertical = " + Controller.rightStickVertical +  "\n\n";
        leftTriggers += "leftStickClick = " + Controller.leftStickClick + "\n";
        leftTriggers += "rightStickClick = " + Controller.rightStickClick + "\n\n";
        leftTriggers += "startButton = " + Controller.startButton + "\n\n";


        var rightTriggers = "buttonA = " + Controller.buttonA + "\n";
        rightTriggers += "buttonB = " + Controller.buttonB + "\n";
        rightTriggers += "buttonX = " + Controller.buttonX + "\n";
        rightTriggers += "buttonY = " + Controller.buttonY + "\n\n";
        rightTriggers += "rightBumper = " + Controller.rightBumper + "\n";
        rightTriggers += "leftBumper = " + Controller.leftBumper + "\n";
        rightTriggers += "rightTrigger = " + Controller.rightTrigger + "\n";
        rightTriggers += "leftTrigger = " + Controller.leftTrigger + "\n\n";


        controllerTextBox.GetComponent<Text>().text = "Controller = " + Controller.controller;
        leftTextBox.GetComponent<Text>().text = leftTriggers;
        rightTextBox.GetComponent<Text>().text = rightTriggers;
	}
}
