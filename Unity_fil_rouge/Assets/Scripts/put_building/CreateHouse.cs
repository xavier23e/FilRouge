using UnityEngine;
using System.Collections;

public class CreateHouse : MonoBehaviour {
	public GameObject house;
	// Use this for initialization
	void Start () {
		Instantiate (house, Input.mousePosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
