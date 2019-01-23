using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public Text textHighscore;
	public Text textScore;
	public static int highscoreValue;
	public static int scoreValue;

	void Start()
	{
		highscoreValue = PlayerPrefs.GetInt ("highscore");
		scoreValue = PlayerPrefs.GetInt ("score");
	}

	// Update is called once per frame
	void Update () {

		ScoreManager.score = 0;
		PlayerPrefs.SetInt ("score", 0);

		/*int fingerCount = 0;
		foreach (Touch touch in Input.touches){
			if (touch.phase == TouchPhase.Began && touch.phase != TouchPhase.Canceled)
			{
				fingerCount++;
			}
		}
			
		if (fingerCount == 1 || Input.GetKeyDown(KeyCode.Space)) {
			SceneManager.LoadScene ("Gameplay", LoadSceneMode.Single);
		}*/
			
		textHighscore.text = highscoreValue.ToString ();
		textScore.text = scoreValue.ToString ();
	}
}
