using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {

	public GUIStyle menuTitle;
	public GUIStyle infoText;

	void OnGUI () {
		// Title Text
		// TODO: Replace with texture...
		int titleWidth = 100;
		int titleHeight = 100;
		GUI.Label (new Rect (Screen.width / 2 - titleWidth/2, 
		                  Screen.height / 2 - titleHeight,
		                  titleWidth,
		                  titleHeight),
		         "Crowbots",
		           menuTitle);

		// Version
		int versionWidth = 50;
		int versionHeight = 20;
		GUI.Label (new Rect (Screen.width - versionWidth, 
		                     0,
		                     versionWidth,
		                     versionHeight),
		           "v 0.0.1",
		           infoText);

		// Copy Info
		int copyWidth = 150;
		int copyHeight = 20;
		GUI.Label (new Rect (Screen.width - copyWidth, 
		                     Screen.height- copyHeight,
		                     copyWidth,
		                     copyHeight),
		           "SoAndSo Games",
		           infoText);

		// Menu Options
		Vector2 menuSize = new Vector2 (100, 55);
		Vector2 menuLoc = new Vector2 (Screen.width/2 - menuSize.x/2, Screen.height/2);
		GUI.Box(new Rect(menuLoc.x, 
		                 menuLoc.y,
		                 menuSize.x,
		                 menuSize.y),
		        "");

		int optionHeight = 20; // Height of an option-button.

		// Play Button
		if (GUI.Button (new Rect (menuLoc.x + 5,
		                          menuLoc.y + 5,
		                          menuSize.x - 10,
		                          optionHeight),
		            	"Play") ) {
			Application.LoadLevel(1);
		}

		// Exit Button
		if (GUI.Button (new Rect (menuLoc.x + 5,
		                          menuLoc.y + optionHeight + 10,
		                          menuSize.x - 10,
		                          optionHeight),
		            	"Exit")) {
			Application.Quit();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
