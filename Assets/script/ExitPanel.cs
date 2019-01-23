using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ExitPanel : MonoBehaviour , IPointerClickHandler
{
	public GameObject exitPanel;
	public AudioClip audioExitButton;

	private AudioSource mediaPlayExitButton;

	void Start()
	{
		mediaPlayExitButton = gameObject.AddComponent<AudioSource> ();
		mediaPlayExitButton.clip = audioExitButton;
	}


	public void OnPointerClick(PointerEventData eventData)
	{
		mediaPlayExitButton.Play ();
		exitPanel.SetActive (true);
	}
}
