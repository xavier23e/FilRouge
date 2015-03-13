using UnityEngine;
using System.Collections;

public class Texture : MonoBehaviour {

	// La texture à appliquer à la grille de jeu
	public Texture2D map;

	// Le gameobject de la grille de jeu
	public GameObject grille;

	// Nombre de lignes 
	private int row;

	// Nombre de colonnes
	private int column;

	// Use this for initialization
	void Start ()
	{
		row = 0;
		column = 0;

		foreach (Transform cellule in grille.transform)
		{
			//Debug.Log("Couleur du pixel("+row+", "+column+") = " + map.GetPixel(row, column));

			// Si le pixel courant de l'image est noir
			if (map.GetPixel(row, column) == Color.black)
			{
				// On rend le script inactif pour empecher le déplacement de l'objet dessus et ainsi sa construction
				cellule.GetComponent<Case>().actifCase = false;
				// Changement de couleur de la case en noir
				cellule.renderer.material.color = Color.black;
			}
			// Incrémentation de la colonne
			column++;

			// Si on est à la dernière colonne
			if(column >= map.width)
			{
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
