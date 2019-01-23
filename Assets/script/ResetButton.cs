using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ResetButton : MonoBehaviour , IPointerClickHandler
{
	public GameObject resetHighscorepanel;
	public AudioClip audioButton;

	private AudioSource mediaPlayButton;

	void Start()
	{
		mediaPlayButton = gameObject.AddComponent<AudioSource> ();
		mediaPlayButton.clip = audioButton;
	}


	public void OnPointerClick(PointerEventData eventData)
	{
		PlayerPrefs.SetInt ("highscore", 0);
		mediaPlayButton.Play ();
		resetHighscorepanel.SetActive (true);
	}
}
