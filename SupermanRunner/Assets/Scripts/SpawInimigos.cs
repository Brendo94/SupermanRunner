using UnityEngine;
using System.Collections;

public class SpawInimigos : MonoBehaviour {
 	public GameObject posicao1;
    public GameObject posicao2;
	public GameObject criptonita;
	public UnityEngine.UI.Text score;
	public UnityEngine.UI.Text hiScore;
	private int _score, _hiScore;
    

    // Use this for initialization
    void Start()
    {
        Invoke("Launch", 1f);
		_hiScore = PlayerPrefs.GetInt("superRunner_hiscore", 0);
		hiScore.text = "" + _hiScore;
    }

    void Launch()
    {
        if (Random.Range(0, 100) <= 50)
        {
			GameObject nome = GameObject.Instantiate(criptonita) as GameObject;
			nome.transform.position = posicao1.transform.position;
			nome.rigidbody2D.AddForce(-Vector2.up);
        }
        else
        {
			GameObject nome = GameObject.Instantiate(criptonita) as GameObject;
			nome.transform.position = posicao2.transform.position;
			nome.rigidbody2D.AddForce(-Vector2.up);
        }


        Invoke("Launch", Random.Range(1f, 2f));
    }

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "enemy"){
				Destroy(coll.gameObject);
				PlayerScored ();
		}
	}

	void PlayerScored()
	{	
		if (++_score > _hiScore)
		{
			_hiScore = _score;
			hiScore.text = "" + _hiScore;
			PlayerPrefs.SetInt("superRunner_hiscore", _hiScore);
			PlayerPrefs.Save();
		}
		score.text = "" + _score;
	}
}
