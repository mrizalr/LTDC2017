using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class nextButton : MonoBehaviour , IPointerClickHandler
{
	public selectPOPO selectPopo;
	public int currentIndex;
	public AudioClip audioButton;

	private AudioSource mediaPlayButton;

	// Use this for initialization
	void Start () {
		selectPopo = FindObjectOfType<selectPOPO> ();
		currentIndex = selectPopo.selectionIndex;
		mediaPlayButton = gameObject.AddComponent<AudioSource> ();
		mediaPlayButton.clip = audioButton;
	}

	void Update()
	{
		currentIndex = selectPopo.selectionIndex;
	}
	
	public void OnPointerClick(PointerEventData eventData)
	{
		mediaPlayButton.Play ();
		currentIndex += 1;
		selectPopo.Select (currentIndex);
	}
}
