using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitApps : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {
			SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
		}
	}
}
