using UnityEngine;
using System.Collections;

public class CreateGreenHouse : MonoBehaviour {

	public GameObject model;
	private GameObject put;
	public bool isCreated;
	public GameObject grilleDeJeu;
	public string nameObject ="";  

	public void createGreenHouse(){
		
		Gameplay instanceGameplay = new Gameplay();
		Building instanceBuilding = new Building();
		
		if (instanceGameplay.verifRessources( instanceBuilding.get_c_water(), instanceBuilding.get_c_food(),  instanceBuilding.get_c_energy(), instanceBuilding.get_c_humain()) ) {
			
			put = (GameObject)Instantiate (model, new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0), Quaternion.identity);
			put.name = nameObject;
			isCreated = true;
			for (int i = 0; i< grilleDeJeu.transform.childCount; i++) {
				Transform scriptCase = grilleDeJeu.transform.GetChild (i);
				scriptCase.GetComponent<Case> ().item = put;
				Case.itemPlaced = false;
			}
		}
	}
}