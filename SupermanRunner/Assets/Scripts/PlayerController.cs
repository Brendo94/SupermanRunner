using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector3 _dir;

    // Use this for initialization
    void Start()
    {
        _dir = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToViewportPoint(
                Input.mousePosition
                );

            if (pos.y > 0.5)
                _dir = Vector3.up;
            else if (pos.y < 0.5)
                _dir = Vector3.down;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _dir = Vector3.zero;
        }
    }

    void FixedUpdate()
    {
        transform.Translate(speed * _dir);
        //transform.position += speed * _dir;
    }
}
