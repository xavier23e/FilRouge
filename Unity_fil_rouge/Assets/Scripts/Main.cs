using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Objet grille de jeu
	private GameGridClass gameGrid;

	// Prefab d'une case
	public GameObject caseModel;

	// Variable qui contiendra chaque case instanciée
	private GameObject caseObject;

	// Nombre de case
	private int nbCase;

	// Game object vide qui regroupe toutes les cases
	public GameObject gameGridObject;

	// Use this for initialization
	void Awake () {
			// Création d'un objet de type GameGridClass qui représente la grilel de jeu 
			gameGrid = new GameGridClass (32, 32);
			
			// Coordonnée x de la case
			float x = 0f;
			
			for (int i=0; i<gameGrid.row; i++)
			{
				// Coordonné z de la case
				float z = 0f;
				for (int j=0; j<gameGrid.column; j++)
				{
					// Instanciation de la case dans le jeu
					caseObject = (GameObject) Instantiate(caseModel);//, new Vector3(x, 0f, z), Quaternion.identity);
					
					// Renommager de la case
					caseObject.name = "Case"+nbCase;
					
					// Attribution d'un parent qui est un game object vide appelé 'Grille de jeu' à cette case
					caseObject.transform.parent = gameGridObject.transform;
					caseObject.GetComponent<Case>().item = new GameObject();
					caseObject.transform.localPosition = new Vector3(x,0f,z);
					caseObject.renderer.material.color = new Color(caseObject.renderer.material.color.r, caseObject.renderer.material.color.g, caseObject.renderer.material.color.b, 0.5f);
					nbCase++;
					z++;
					//Debug.Log("x = "+x+" z = "+z);
				}
				x++;
			}			
	}
	
	// Update is called once per frame
	void Update () {


	}
}
