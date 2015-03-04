using UnityEngine;
using System.Collections;

public class Case : MonoBehaviour {

	private GameObject item;
	//[HideInInspector]
	public bool actif;
	private bool placed;

	// Use this for initialization
	void Awake () {
		item = GameObject.Find ("Item");
		Debug.Log ("item=" + item.name);
		actif = true;
		placed = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Au survol de la souris
	void OnMouseOver() {
		if (actif && !placed) {
			//renderer.material.color = Color.red;
			item.transform.position = transform.position;
		}
	}

	void OnMouseExit() {
		if (actif) {
			renderer.material.color = Color.white;
		}
	}

	void OnMouseDown () {
		placed = true;
		Debug.Log ("Item placed");
	}
}
