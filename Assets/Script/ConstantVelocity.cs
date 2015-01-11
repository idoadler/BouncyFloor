using UnityEngine;
using System.Collections;

public class ConstantVelocity : MonoBehaviour {

	public float velocity = 2;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
//		foreach(Transform child in transform)
//		{
			rigidbody2D.velocity=new Vector2(velocity,rigidbody2D.velocity.y);
//		}	
	}
}
