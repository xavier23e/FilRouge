using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	// Variable pour savoir si l'objet est sélectionné ou pas
	private bool itemSelected;

	// Use this for initialization
	void Start () {
		itemSelected = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (itemSelected) {
			//Debug.Log ("Item selectionné :"+itemSelected);
			transform.position = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		}
	}

	void OnMouseDown () {
		Debug.Log ("Item clické");
		if (itemSelected) {
			itemSelected = false;
		} else {
			itemSelected = true;
		}
		Debug.Log ("Item selected : "+itemSelected);
	}
}
