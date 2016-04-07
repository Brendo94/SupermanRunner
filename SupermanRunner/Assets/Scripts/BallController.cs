using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    private GameObject _manager;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(300, 150));
        _manager = GameObject.FindGameObjectWithTag("GManager");
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter2D(Collision2D c)
    {
        _manager.SendMessage("UpdateScore", c.gameObject.tag);
    }
}
