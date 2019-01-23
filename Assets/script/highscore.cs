using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highscore : MonoBehaviour {

	public Text hsValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		hsValue.text = PlayerPrefs.GetInt ("highscore").ToString();
	}
}
