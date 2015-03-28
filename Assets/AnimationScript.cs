using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0) {
			anim.SetInteger ("AnimationState", 1);
			//Debug.Log ("Walking");
		} else {
			anim.SetInteger ("AnimationState", 0);
			//Debug.Log ("Still");
		}
	}
}
