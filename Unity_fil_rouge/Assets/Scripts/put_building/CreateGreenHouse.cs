using UnityEngine;
using System.Collections;

public class CreateGreenHouse : MonoBehaviour {
	public GameObject greenHouse;
	// Use this for initialization
	void Start () {
		Instantiate (greenHouse, Input.mousePosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
