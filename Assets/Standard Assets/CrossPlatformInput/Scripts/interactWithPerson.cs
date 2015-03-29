using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class interactWithPerson : MonoBehaviour {
	
	public Text guitext;
	
	private int count;
	private string[] messages;
	private int numMessages;
	private Vector3 center;
	private Vector3 npcCenter;
	private float radius;
	
	
	// Use this for initialization
	void Start () {
		count = 0;
		guitext.text = "";
		radius = 6; //I have no idea what number to put here...
		
		numMessages = 9;
		messages = new string[numMessages];
		
		messages[0] = "Hey.";
		messages[1] = "How are you doing?";
		messages[2] = "Nice weather, huh?";
		messages[3] = "Watch where you're going!";
		messages[4] = "Ow, you stepped on my foot!";
		messages[5] = "Sup?";
		messages[6] = "Where are you going?";
		messages[7] = "Would you like directions?";
		messages[8] = "Can I come along?";
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//find where the player is
		GameObject player = GameObject.FindGameObjectWithTag ("MainCamera");
		center = player.transform.position;
		
		// find where important npc is
		GameObject npc = GameObject.FindGameObjectWithTag ("ImportantNPC");
		npcCenter = npc.transform.position;
		//guitext.text = (Vector3.Distance (center, npcCenter)).ToString();
		
		//find objects within a certain radius from where the player is
		//Collider[] hitColliders = Physics.OverlapSphere(center, radius);
		//Debug.Log (hitColliders.GetLength(0).ToString ());
		
		
		
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Pressed left click.");
			
			if (((Vector3.Distance (center, npcCenter)) < radius) && (count < numMessages)) {
				displayText ();
			} else {
				guitext.text = "";
				if (count >= numMessages) {
					count = 0;
				}
			}
		}
		
	}
	
	void displayText() {
		Debug.Log ("Bumped into a person");
		Debug.Log ("C is: " + count.ToString());
		guitext.text = messages[count];
		count++;
	}
}

