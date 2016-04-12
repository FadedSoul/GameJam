using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	private GameObject rondje;
	public GameObject[] items;

	// Use this for initialization
	void Start () {
		//rondje = Resources.Load<GameObject> ("Rondje_1");
		//Instantiate (rondje, new Vector2 (0, 0), rondje.transform.rotation);
		for (int i = 0; i < items.Length; i++) {
			Instantiate (items[i], new Vector2 (i, i), items[i].transform.rotation);
		
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
		
}
