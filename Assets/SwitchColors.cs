using UnityEngine;
using System.Collections;

public class SwitchColors : MonoBehaviour {

	Renderer rend;
	public Color white = Color.white;

	public Color orig_color;

	public bool isColor;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		orig_color = rend.material.color;
		isColor = true;
	}
	
	// Update is called once per frame
	void Update () {
		switch_colors (isColor);
	
	}

	void switch_colors (bool is_color) {
		if (is_color) {
			if (Input.GetKeyDown (KeyCode.F)) {
				rend.material.SetColor ("_Color", white);
				rend.material.SetColor ("_Emission", white);
				isColor = (!is_color);
			}
		}
		else {
			if (Input.GetKeyDown (KeyCode.F)) {
				rend.material.SetColor ("_Color", orig_color);
				rend.material.SetColor ("_Emission", orig_color);
				isColor = (!is_color);
			}
		}
	}
}
