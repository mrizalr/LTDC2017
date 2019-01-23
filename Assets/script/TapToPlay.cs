using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TapToPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int fingerCount = 0;
		foreach (Touch touch in Input.touches){
			if (touch.phase == TouchPhase.Began && touch.phase != TouchPhase.Canceled)
			{
				fingerCount++;
			}
		}

		if (fingerCount == 1 || Input.GetKeyDown(KeyCode.Space)) {
			SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
		}
	}
}
