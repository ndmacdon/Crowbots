using UnityEngine;
using System.Collections;

public class RobotBuilderGUI : MonoBehaviour {
	const int Pad = 5;
	bool exiting = false;
	Vector2 buttonSize = new Vector2 (70, 20);
	Vector2 exitSize = new Vector2(155, 100);
	Vector2 exitLoc = new Vector2(Screen.width/2 - 155/2, 
	                              Screen.height/2 - 100/2);

	void OnGUI () {

		// Toolbox
		// -------

		// Selection Settings
		// ------------------

		// Camera
		// ------

		// Zoom-In Button
		// TODO: Replace text with graphic.
		// The first time I have ever coded a non-short-circuit condition...
		if (Camera.main.orthographicSize > .1 & 
		    GUI.RepeatButton (new Rect (Pad, 
		                                Screen.height - (buttonSize.y + Pad),
		                                buttonSize.x,
		                                buttonSize.y),
		                      "Zoom-In") ) {
			Camera.main.orthographicSize -= .05f;
		}

		// Zoom-Out Button
		// TODO: Replace text with graphic.
		if (GUI.RepeatButton (new Rect (buttonSize.x + Pad*2, 
		                                Screen.height - (buttonSize.y + Pad),
		                                buttonSize.x,
		                                buttonSize.y),
		                      "Zoom-Out") ) {
			Camera.main.orthographicSize += .05f;
		}


		// Navigation
		// ----------

		// Exit-Builder Button
		// TODO: Replace text with graphic.
		if (GUI.Button (new Rect (Pad,
		                          Pad,
		                          buttonSize.x,
		                          buttonSize.y),
		                "Exit") ) {
			exiting = true;
		}

		// Confirm player wants to exit:
		if (exiting) {
			GUI.Box(new Rect(exitLoc.x,
			                 exitLoc.y,
			                 exitSize.x,
			                 exitSize.y),
			        "Exit?");
			// Yes, Exit:
			if (GUI.Button (new Rect (exitLoc.x + Pad,
			                          exitLoc.y + 20 + Pad,
			                          buttonSize.x,
			                          buttonSize.x),
			                "Confirm") ) {
				Application.LoadLevel(0);
			}

			// No, DON'T Exit:
			if (GUI.Button (new Rect (exitLoc.x + buttonSize.x + Pad*2,
			                          exitLoc.y + 20 + Pad,
			                          buttonSize.x,
			                          buttonSize.x),
			                "Cancel") ) {
				exiting = false;
			}

		}


		// Save-Robot Button
		// TODO: Replace text with graphic.
		if (GUI.Button (new Rect (buttonSize.x + Pad*2,
		                          Pad,
		                          buttonSize.x,
		                          buttonSize.y),
		                "Save") ) {
			// TODO: Add save functionality...
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
