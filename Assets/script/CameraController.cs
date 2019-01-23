using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	//public PlayerMovement thePlayer;
	public GameObject player;

	private Vector3 lastPlayerPosition;
	private float distanceToMove;

	// Use this for initialization
	void Start () {
		//thePlayer = FindObjectOfType<PlayerMovement> ();
		lastPlayerPosition = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		distanceToMove = player.transform.position.x - lastPlayerPosition.x;
		transform.position = new Vector3 (transform.position.x + distanceToMove, transform.position.y, transform.position.z);
		lastPlayerPosition = player.transform.position;
	}
}
