using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour {

	public PlayerMovement player;
	public GameObject deathParticle;
	public bool playerDie;
	public float timerGameover = 0;
	public AudioClip audioCrash;

	private AudioSource mediaPlayCrash;

	// Use this for initialization
	void Start () {
		mediaPlayCrash = gameObject.AddComponent<AudioSource> ();
		mediaPlayCrash.clip = audioCrash;
		player = FindObjectOfType<PlayerMovement> ();
		playerDie = false;
	}

	void Update ()
	{
		if (playerDie) {
			timerGameover += Time.deltaTime;
			if(timerGameover>1)
				SceneManager.LoadScene ("Gameover", LoadSceneMode.Single);
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			Instantiate (deathParticle, player.transform.position, player.transform.rotation);
			player.enabled = false;
			player.GetComponent<Renderer> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			playerDie = true;
			mediaPlayCrash.Play ();
		}
	}
}
