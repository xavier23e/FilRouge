using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateDrilling : MonoBehaviour {
	public GameObject modelDrilling;
	private GameObject drillingPut;
	public bool isCreated;
	public GameObject grilleDeJeu;

	public void createDrilling(){

		drillingPut = (GameObject)Instantiate (modelDrilling, new Vector3(Input.mousePosition.x,Input.mousePosition.y, 0), Quaternion.identity);
		drillingPut.name = "drilling";
		isCreated = true;
			for (int i = 0; i< grilleDeJeu.transform.childCount; i++) {
				Transform scriptCase = grilleDeJeu.transform.GetChild(i);
				scriptCase.GetComponent<Case>().item = drillingPut;
				Case.itemPlaced = false;
			}

	}
}
