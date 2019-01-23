using UnityEngine;
public class Obstacles : MonoBehaviour {
	public float jeda = 0.8f;
	float timer;
	public GameObject[] spearPrefabs;
	public GameObject[] spearPosition= new GameObject[2];

	// Use this for initialization
	void Start()
	{
	}
	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		if (timer > jeda)
		{
			int randomPlace = Random.Range (0, spearPosition.Length);

			if (randomPlace == 0)
				Instantiate (spearPrefabs [0], spearPosition [randomPlace].transform.position, Quaternion.Euler (0, 0, 0));
			else if (randomPlace == 1)
				Instantiate (spearPrefabs [1], spearPosition [randomPlace].transform.position, Quaternion.Euler (0, 0, 0));
			else if (randomPlace == 2)
				Instantiate (spearPrefabs [2], spearPosition [randomPlace].transform.position, Quaternion.Euler (0, 0, 0));
			else if (randomPlace == 3)
				Instantiate (spearPrefabs [3], spearPosition [randomPlace].transform.position, Quaternion.Euler (0, 0, 0));
			timer = 0;
		}
	}
}