using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject txtStart;
    public TextMesh playerScore;
    public TextMesh computerScore;

    private int _playerScore;
    private int _computerScore;

    private bool _isAlive;

    // Use this for initialization
    void Start()
    {
        _isAlive = false;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isAlive)
        {
            if (Input.GetMouseButtonDown(0))
            {
                txtStart.SetActive(false);
                Time.timeScale = 1f;
                _isAlive = true;
            }
        }
    }

    void UpdateScore(string tag)
    {
        if (tag.Equals("LWall"))
        {
            _computerScore++;
            computerScore.text = "" + _computerScore;
        }
        else if (tag.Equals("RWall"))
        {
            _playerScore++;
            playerScore.text = "" + _playerScore;
        }
    }
}
