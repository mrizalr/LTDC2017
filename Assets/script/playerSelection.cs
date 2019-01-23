using UnityEngine;
using System.Collections;

public class playerSelection : MonoBehaviour {

	public GameObject[] playerOption;
	public int playerIndex;

	// Use this for initialization
	void Start () {
		playerIndex = PlayerPrefs.GetInt ("popo");
	}
	
	// Update is called once per frame
	void Update () {
		EnableCharacter ();
	}

	public void EnableCharacter()
	{
		if (playerIndex == 0) {
			playerOption [0].SetActive (true);
			playerOption [1].SetActive (false);
			playerOption [2].SetActive (false);
			playerOption [3].SetActive (false);
			playerOption [4].SetActive (false);
			playerOption [5].SetActive (false);
			playerOption [6].SetActive (false);
		}

		else if (playerIndex == 1) {
			playerOption [0].SetActive (false);
			playerOption [1].SetActive (true);
			playerOption [2].SetActive (false);
			playerOption [3].SetActive (false);
			playerOption [4].SetActive (false);
			playerOption [5].SetActive (false);
			playerOption [6].SetActive (false);
		}

		else if (playerIndex == 2) {
			playerOption [0].SetActive (false);
			playerOption [1].SetActive (false);
			playerOption [2].SetActive (true);
			playerOption [3].SetActive (false);
			playerOption [4].SetActive (false);
			playerOption [5].SetActive (false);
			playerOption [6].SetActive (false);
		}

		else if (playerIndex == 3) {
			playerOption [0].SetActive (false);
			playerOption [1].SetActive (false);
			playerOption [2].SetActive (false);
			playerOption [3].SetActive (true);
			playerOption [4].SetActive (false);
			playerOption [5].SetActive (false);
			playerOption [6].SetActive (false);
		}

		else if (playerIndex == 4) {
			playerOption [0].SetActive (false);
			playerOption [1].SetActive (false);
			playerOption [2].SetActive (false);
			playerOption [3].SetActive (false);
			playerOption [4].SetActive (true);
			playerOption [5].SetActive (false);
			playerOption [6].SetActive (false);
		}

		else if (playerIndex == 5) {
			playerOption [0].SetActive (false);
			playerOption [1].SetActive (false);
			playerOption [2].SetActive (false);
			playerOption [3].SetActive (false);
			playerOption [4].SetActive (false);
			playerOption [5].SetActive (true);
			playerOption [6].SetActive (false);
		}

		else if (playerIndex == 6) {
			playerOption [0].SetActive (false);
			playerOption [1].SetActive (false);
			playerOption [2].SetActive (false);
			playerOption [3].SetActive (false);
			playerOption [4].SetActive (false);
			playerOption [5].SetActive (false);
			playerOption [6].SetActive (true);
		}
	}
}
