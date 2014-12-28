using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

	public CubeController cubeController;

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI() {

		if (GUILayout.Button ("Example 1")) {
				
			cubeController.Example1();

		}
		
		if (GUILayout.Button ("Example 2")) {

			cubeController.Example2();

		}
		
	}
}
