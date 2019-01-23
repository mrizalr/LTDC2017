using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour , IPointerClickHandler
{
	public string targetScene;
	public AudioClip audioButton;

	private AudioSource mediaPlayButton;

	void Start()
	{
		mediaPlayButton = gameObject.AddComponent<AudioSource> ();
		mediaPlayButton.clip = audioButton;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		mediaPlayButton.Play ();
		SceneManager.LoadScene(targetScene);
	}
}
