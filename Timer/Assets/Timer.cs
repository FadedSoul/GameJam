using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text uiText;
    private float time;


    void Start () {
        time = 0f;
	}
	
	void Update () {
	    if (uiText != null)
        {
            uiText.text = "Time: " + time.ToString("f0");
        }
        time += Time.deltaTime;
	}
}
