using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateBuilding : MonoBehaviour {
	public GameObject model;
	private GameObject put;
	public bool isCreated;
	public GameObject grilleDeJeu;
	public string nameObject = "";  
	private Building instanceBuilding;

	public void createBuilding(){

		Gameplay instanceGameplay = new Gameplay();

		switch (nameObject){
			case "solar" :
				instanceBuilding = new SolarPanel();
				break;
			case "drilling" :
				instanceBuilding = new Drilling();
				break;
			case "windturbine" :
				instanceBuilding = new WindTurbine();
				break;
			case "habitation" :
				instanceBuilding = new Habitation();
				break;
			case "greenHouse" :
				instanceBuilding = new Greenhouse();
				break;
			}

		if (instanceGameplay.verifRessources( instanceBuilding.get_c_water(), instanceBuilding.get_c_food(), instanceBuilding.get_c_energy(), instanceBuilding.get_c_humain()) ) {
			Debug.Log("Creation batiment");
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