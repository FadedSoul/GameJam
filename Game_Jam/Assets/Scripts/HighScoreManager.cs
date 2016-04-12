using UnityEngine;
using UnityEngine.UI;


public class HighScoreManager : MonoBehaviour
{
    //UNFINISHED
    [SerializeField]
    //private bool _scoreReset = false;

    Text HighscoreText;
    //private int _highScoreEasy;
    //private int _highScoreNormal;
    //private int _highScoreHard;
    private int _score;

    // Use this for initialization
    void Awake()
    {
        HighscoreText = GetComponent<Text>();
        _score = GameManager.playerScore;
        //_highScoreEasy = GameManager.playerHighScore;
        //_highScoreNormal = GameManager.playerHighScore;
        //_highScoreHard = GameManager.playerHighScore;
        if (_score > GameManager.playerHighScoreEasy && GameManager.lastLevel == 1)
        {
            GameManager.playerHighScoreEasy = _score;
            UpdateScore();
        }
        else if (_score > GameManager.playerHighScoreNormal && GameManager.lastLevel == 2)
        {
            GameManager.playerHighScoreNormal = _score;
            UpdateScore();
        }
        else if (_score > GameManager.playerHighScoreHard && GameManager.lastLevel == 3)
        {
            GameManager.playerHighScoreHard = _score;
            UpdateScore();
        }
        else
        {
            UpdateScore();
        }

    }

    private void UpdateScore()
    {
        switch (GameManager.lastLevel)
        {
            case (1):
                UpdateHighScoreEasy();
                break;
            case (2):
                UpdateHighScoreNormal();
                break;
            case (3):
                UpdateHighScoreHard();
                break;
            default:
                break;
        }
    }

    void UpdateHighScoreEasy()//Easy
    {
        HighscoreText.text = "HighScore: " + GameManager.playerHighScoreEasy + " :Easy";
    }

    void UpdateHighScoreNormal()//Normal
    {
        HighscoreText.text = "HighScore: " + GameManager.playerHighScoreNormal + " :Normal";
    }

    void UpdateHighScoreHard()//Hard
    {
        HighscoreText.text = "HighScore: " + GameManager.playerHighScoreHard + " :Hard";
    }

}
