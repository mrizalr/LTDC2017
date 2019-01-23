using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int score;
	public static int highScore;

	public float timer = 0;
	public Text textScore;

	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt ("highscore");
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer > 3f) {
			score += 25;
			textScore.text = score.ToString ();
			PlayerPrefs.SetInt ("score", score);
			timer = 0f;
		}

		if (score > highScore) {
			highScore = score;
			PlayerPrefs.SetInt ("highscore", highScore);
		}
	}
}
