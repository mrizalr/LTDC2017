using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class popoSelect : MonoBehaviour , IPointerClickHandler
{
	public GameObject successPanel;
	public selectPOPO popoSelectIndex;
	public int indexOfPopo;
	public AudioClip audioButton;

	private AudioSource mediaPlayButton;

	// Use this for initialization
	void Start () {
		popoSelectIndex = FindObjectOfType<selectPOPO> ();
		mediaPlayButton = gameObject.AddComponent<AudioSource> ();
		mediaPlayButton.clip = audioButton;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		indexOfPopo = popoSelectIndex.selectionIndex;
		PlayerPrefs.SetInt ("popo", indexOfPopo);
		mediaPlayButton.Play ();
		successPanel.SetActive (true);

	}
}
