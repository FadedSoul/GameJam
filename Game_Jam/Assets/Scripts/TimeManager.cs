using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public int timeIsUpLevel = 4;
    public int winLevel = 5;

    public float winScore = 100;

    private int _currentScore = GameManager.playerScore;

    [SerializeField]
    float _timeleft = 10.0f;
    [SerializeField]
    bool _minScore = false;
    Text timeText;



    // Use this for initialization
    void Awake()
    {
        timeText = GetComponent<Text>();
        UpdateTimer();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _timeleft -= Time.deltaTime;
        UpdateTimer();
        if (_timeleft <= 0)
        {
            OutOfTime();
        }
    }
    void UpdateTimer()
    {
        timeText.text = "Time left: " + _timeleft;
    }

    private void OutOfTime()
    {
        GameManager.lastLevel = Application.loadedLevel;
        if (_currentScore >= winScore && _minScore == true)
        {
            Application.LoadLevel(winLevel);
        }
        else
        {
            Application.LoadLevel(timeIsUpLevel);
        }

    }
}
