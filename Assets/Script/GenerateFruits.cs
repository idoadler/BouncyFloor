using UnityEngine;
using System.Collections;

public class GenerateFruits : MonoBehaviour {
	
	public float objectsNum = 1;
	public float minDelay = 1.2f;
	public float maxDelay = 1.5f;

	public GameObject[] fruits;

	void LaunchFruits() {
		GameObject instance = (GameObject)Instantiate(fruits[Random.Range(0,fruits.Length)]);
		instance.transform.parent = transform;
	}

	// Use this for initialization
	void Start () {
		InvokeRepeating("LaunchFruits", minDelay, minDelay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
