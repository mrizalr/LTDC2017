using UnityEngine;
using System.Collections;

public class playerChanger : MonoBehaviour {

	public GameObject[] popoCharacter;
	public GameObject popoCharChoosen;
	public popoSelect selectPopoChange;
	public int popoIndex;

	// Use this for initialization
	void Start () {
		selectPopoChange = FindObjectOfType <popoSelect> ();
		popoIndex = PlayerPrefs.GetInt ("popo");
		popoCharChoosen = popoCharacter [popoIndex];
		GameObject go = Instantiate (popoCharChoosen, transform.position, transform.rotation) as GameObject;
		GameObject.Find ("Player").transform.parent = go.transform;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
