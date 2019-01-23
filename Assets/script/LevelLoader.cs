using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public int indexPopoChoose;
	public GameObject loadingScreen;
	public Slider slider;
	public Text LoaderText;
	public AudioClip audioButton;

	private AudioSource mediaPlayButton;

	void Start()
	{
		indexPopoChoose = PlayerPrefs.GetInt ("popo");
		mediaPlayButton = gameObject.AddComponent<AudioSource> ();
		mediaPlayButton.clip = audioButton;
	}

	public void LoadLevel(int sceneIndex)
	{
		mediaPlayButton.Play ();
		StartCoroutine (LoadAsynchronously (sceneIndex));
	}

	IEnumerator LoadAsynchronously(int sceneIndex)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);

		loadingScreen.SetActive (true);

		while (!operation.isDone) {
			float progress = Mathf.Clamp01 (operation.progress / .9f);

			slider.value = progress;
			LoaderText.text = progress * 100 + "%";

			yield return null;
		}
	}

}
