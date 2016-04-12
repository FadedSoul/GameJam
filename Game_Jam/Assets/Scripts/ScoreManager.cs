using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private bool _scoreReset = false;

    Text scoreText;
    // Use this for initialization
    void Awake()
    {
        scoreText = GetComponent<Text>();
        if (_scoreReset)
        {
            GameManager.playerScore = 0;
        }
        UpdateScore();
    }

    void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + GameManager.playerScore;
    }
}