
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	Vector3 direita = new Vector3(1.22f, -3.6f,-1);
	Vector3 esquerda = new Vector3(-1.22f, -3.6f,-1);
	int vida;
	// Use this for initialization
	void Start () {
		transform.position = esquerda;
		vida = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {
			transform.position = direita;
		}else if(Input.GetKey("left")){
			transform.position = esquerda;
		}
		if(vida==0) {
			Destroy (this.gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "enemy") {
			vida = vida - 1;

			//Application.loadLevel();
		}
	}
	
}
