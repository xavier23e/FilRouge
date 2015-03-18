using UnityEngine;
using System.Collections;

public class Case : MonoBehaviour {

	public GameObject item = null;
	//[HideInInspector]
	public bool actifCase;
	public static bool itemPlaced = false;
	private Shader shader;
	// Use this for initialization
	void Awake () {
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
