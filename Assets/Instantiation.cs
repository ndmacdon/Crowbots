using UnityEngine;
using System.Collections;

public class Instantiation : MonoBehaviour {
	
	// C#
	public Transform brick;
	
	void Start() {
		Debug.Log("Entered Start");
		StartCoroutine (spawnBrick ());
	}

	IEnumerator spawnBrick() {
		Debug.Log("Entered spawn");

		for (int y = 0; y < 5; y++) {
			for (int x = 0; x < 5; x++) {
				Instantiate (brick, new Vector3 (x, y, 0), Quaternion.identity);
				yield return new WaitForSeconds (2);
			}
		}
	}
}

