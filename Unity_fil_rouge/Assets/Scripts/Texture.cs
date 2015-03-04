using UnityEngine;
using System.Collections;

public class Texture : MonoBehaviour {

	public Texture2D map;

	public GameObject grille;

	private int row;
	private int column;

	// Use this for initialization
	void Start () {

		row = 0;
		column = 0;

		foreach (Transform cellule in grille.transform) {
			Debug.Log("Couleur du pixel("+row+", "+column+") = " + map.GetPixel(row, column));
			//Debug.Log(cellule.name);
			// Si le pixel courant de l'image est noir
			if (map.GetPixel(row, column) == Color.black) {
				// On rend le script inactif pour empecher la construction
				cellule.GetComponent<Case>().actif = false;
				cellule.renderer.material.color = Color.black;
			}

			// Incrémentation de la colonne
			column++;

			// Si on est à la dernière colonne
			if(column >= map.width) {
				// On revient à la première colonne
				column = 0;
				// On incrémente la ligne
				row++;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
