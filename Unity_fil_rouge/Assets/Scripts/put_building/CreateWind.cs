using UnityEngine;
using System.Collections;

public class CreateWind : MonoBehaviour {
	public GameObject wind;
	// Use this for initialization
	void Start () {
		Instantiate (wind, Input.mousePosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
