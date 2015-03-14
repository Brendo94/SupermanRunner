using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	int cont;

	// Use this for initialization
	void Start () {
		cont = 1;
	}
	
	// Update is called once per frame
	void Update () {
		cont++;
		if(cont==100) {
			Destroy(this.gameObject);
		}
	}
}
