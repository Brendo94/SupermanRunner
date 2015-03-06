using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (transform.position.x, transform.position.y - 0.01f);

	}

	void OnCollisionEnter2D(Collision2D coll){

				transform.position = new Vector3 (0, 0.89f, 0);

	}
}
