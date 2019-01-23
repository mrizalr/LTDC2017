using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D myRigidbody;
	public float playerSpeed = 3f;
	public bool isGrounded;
	public AudioClip audioJump;

	private AudioSource mediaPlayJump;
	[SerializeField]
	private Transform groundPoint;
	[SerializeField]
	private float groundRadius;
	[SerializeField]
	private LayerMask groundLayer;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();
		mediaPlayJump = gameObject.AddComponent<AudioSource> ();
		mediaPlayJump.clip = audioJump;
	}
	
	// Update is called once per frame
	void Update () {
		isGrounded = Physics2D.OverlapCircle (groundPoint.position, groundRadius, groundLayer);

		//tap to jump
		int fingerCount = 0;
		foreach (Touch touch in Input.touches){
			if (touch.phase == TouchPhase.Began && touch.phase != TouchPhase.Canceled)
			{
				fingerCount++;
			}
		}

		myRigidbody.velocity = new Vector2 (playerSpeed, myRigidbody.velocity.y);

		if ((fingerCount == 1 || Input.GetKeyDown(KeyCode.Space)) && isGrounded) {
			myRigidbody.gravityScale *= -1;
			FlipPlayer ();
			mediaPlayJump.Play ();
		}
	}

	void FlipPlayer()
	{
		Vector3 theScale = transform.localScale;

		theScale.y *= -1;

		transform.localScale = theScale;
	}
}
