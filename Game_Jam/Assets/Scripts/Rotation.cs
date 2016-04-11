using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    private float Speed;
	// Use this for initialization
	void Start () {
        Speed = 10f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, Time.deltaTime * Speed);

        if(Speed > 10)
        {
            if (Input.GetKey(KeyCode.A))
                Speed -= 1f;
        }

        if (Speed < 100)
        {
            if (Input.GetKey(KeyCode.D))
                Speed += 1f;
        }
	}
}
