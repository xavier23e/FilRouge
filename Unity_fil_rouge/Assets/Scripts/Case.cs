using UnityEngine;
using System.Collections;

public class Case : MonoBehaviour {

	private GameObject item;
	//[HideInInspector]
	public bool actifCase;
	private static bool itemPlaced = false;
	private Shader shader;

	// Use this for initialization
	void Awake () {
		item = GameObject.Find ("drilling");
		Debug.Log ("item=" + item.name);
		actifCase = true;
		shader = Shader.Find("Diffuse");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Au survol de la souris
	void OnMouseOver() {
		if (actifCase && !itemPlaced) {
			// Déplacement de l'item sur la case
			item.transform.position = transform.position;
		}
	}

	void OnMouseDown () {
		itemPlaced = true;
		Debug.Log ("Item placé :" + itemPlaced);

		// Changement du shader (transparent à diffusé)
		//item.GetComponent<Renderer> ().material.shader = shader;
	}
}
