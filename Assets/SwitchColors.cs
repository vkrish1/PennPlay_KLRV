using UnityEngine;
using System.Collections;

public class SwitchWorld : MonoBehaviour {

	bool startSwitchIntoColor = true;

	// Use this for initialization
	void Start () {
		startSwitchIntoColor = true;
	}
	
	// Update is called once per frame
	void Update () {

		//generate a random color
		Color myColor = new Color(Random.Range(0.0,1.0),Random.Range(0.0,1.0),Random.Range(0.0,1.0));

		//find the person we're going to change
		Transform person = this.transform;

		//change the color of that person to myColor
		if(startSwitchIntoColor == true){			
			person.renderer.material.color = myColor;
		}
	
	}
}
