using UnityEngine;
using System.Collections;

public class Criptonita : MonoBehaviour {
	public GameObject mini_Crip;
	ForceMode2D forca;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
			Destroy (this.gameObject);

	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player") {
			for (int cont=0;cont<5;cont++) {
				GameObject nome = GameObject.Instantiate(mini_Crip) as GameObject;
				nome.transform.position = this.gameObject.transform.position;
				if(cont%2==0) {
					nome.rigidbody2D.AddForce(new Vector2(Random.value*1000,Random.value*1000));
				} else {
					nome.rigidbody2D.AddForce(new Vector2(-Random.value*1000,Random.value*1000));
				}


			}
			Destroy (this.gameObject);
			
			//Application.loadLevel();
		}
	}
}
