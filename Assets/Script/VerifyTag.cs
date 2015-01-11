using UnityEngine;
using System.Collections;

public class VerifyTag : MonoBehaviour {
	
	static private int score = 0;
	public string target;
	public TextMesh textScore;
	public int profit = 1;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == target)
		{
			score+=profit;
			if (score < 0)
				score = 0;
			textScore.text = "Score: " + score;
			DestroyObject(other.gameObject);
		}
	}
}
