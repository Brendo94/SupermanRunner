using UnityEngine;
using System.Collections;

public class ComputerController : MonoBehaviour
{
    public GameObject ball;
    private const float speed = 0.025f;
    private Vector3 _dir;
    private Vector3 _pos;

    // Use this for initialization
    void Start()
    {
        _dir = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        _pos = ball.transform.position;

        if (_pos.y > transform.position.y)
            _dir = Vector3.up;
        else if (_pos.y < transform.position.y)
            _dir = Vector3.down;
        else
            _dir = Vector3.zero;
    }

    void FixedUpdate()
    {
        transform.Translate(speed * _dir);
    }
}
