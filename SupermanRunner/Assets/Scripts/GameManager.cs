using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public TextMesh score;
    public TextMesh hiScore;
    private int _score, _hiScore;
    private AudioSource[] _sfx;
    private const int Point = 0, BGM = 1;
    private bool _isPaused;

    // Use this for initialization
    void Start()
    {
        _isPaused = false;
        Time.timeScale = 1f;
        _hiScore = PlayerPrefs.GetInt("ufc_hiscore", 0);
        hiScore.text = "" + _hiScore;

        _sfx = GetComponents<AudioSource>();
        _sfx[BGM].Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_isPaused)
                Application.LoadLevel("Title");
            else
                PauseContinue();
        }

        if (_isPaused)
            if (Input.GetMouseButtonDown(0))
                PauseContinue();
    }

    void PauseContinue()
    {
        // continue
        if (_isPaused)
        {
            _isPaused = false;
            Time.timeScale = 1f;
            _sfx[BGM].Play();
        }
        // pausa
        else
        {
            _isPaused = true;
            Time.timeScale = 0f;
            _sfx[BGM].Pause();
        }
    }
    
    void PlayerScored()
    {
        _sfx[Point].Play();

        if (++_score > _hiScore)
        {
            _hiScore = _score;
            hiScore.text = "" + _hiScore;
            PlayerPrefs.SetInt("ufc_hiscore", _hiScore);
            PlayerPrefs.Save();
        }
        score.text = "" + _score;
    }
}
