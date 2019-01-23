using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformGenerate : MonoBehaviour {

	public GameObject myPlatform;

	private Transform playerTransform;
	private float spawnX = -5.0f;
	private float tileLength = 10.0f;
	private float safeZone = 11f;
	private int amnTilesOnScreen = 5;

	private List<GameObject> activeTiles;

	// Use this for initialization
	void Start () {
		activeTiles = new List<GameObject>();
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		for (int i = 0; i < amnTilesOnScreen; i++) {
			SpawnTile ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (playerTransform.position.x - safeZone> (spawnX - amnTilesOnScreen * tileLength))
		{
			SpawnTile ();
			DeleteTile ();
		}
	}

	private void SpawnTile(int perfabsIndex = -1)
	{
		GameObject go;
		go = Instantiate (myPlatform) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = Vector2.right * spawnX;
		spawnX += tileLength;
		activeTiles.Add (go);
	}

	private void DeleteTile()
	{
		Destroy (activeTiles [0]);
		activeTiles.RemoveAt (0);
	}
}
