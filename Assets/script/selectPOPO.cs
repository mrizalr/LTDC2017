using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class selectPOPO : MonoBehaviour {

	public List<GameObject> popoModels; 
	public int selectionIndex = 0;

	// Use this for initialization
	void Start () {
		popoModels = new List<GameObject> ();
		foreach (Transform t in transform) {
			popoModels.Add (t.gameObject);
			t.gameObject.SetActive (false);
		}
		popoModels [selectionIndex].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Select(int index)
	{
		if (index == selectionIndex)
			return;
		if (index < 0 || index >= popoModels.Count)
			return;

		popoModels [selectionIndex].SetActive (false);
		selectionIndex = index;
		popoModels [selectionIndex].SetActive (true);
	}
}
