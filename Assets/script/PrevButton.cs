using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PrevButton : MonoBehaviour , IPointerClickHandler
{
	public selectPOPO selectPopo;
	public int prevIndex;
	public AudioClip audioButton;

	private AudioSource mediaPlayButton;

	void Start()
	{
		selectPopo = FindObjectOfType<selectPOPO> ();
		prevIndex = selectPopo.selectionIndex;
		mediaPlayButton = gameObject.AddComponent<AudioSource> ();
		mediaPlayButton.clip = audioButton;
	}

	void Update()
	{
		prevIndex = selectPopo.selectionIndex;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		mediaPlayButton.Play ();
		prevIndex -= 1;
		selectPopo.Select (prevIndex);
	}
}
