using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateSolar : MonoBehaviour {
	public GameObject modelSolar;
	private GameObject SolarPut;
	public bool isCreated;
	public GameObject grilleDeJeu;
	
	public void createSolar(){
		
		SolarPut = (GameObject)Instantiate (modelSolar, new Vector3(Input.mousePosition.x,Input.mousePosition.y, 0), Quaternion.identity);
		SolarPut.name = "solar";
		isCreated = true;
		for (int i = 0; i< grilleDeJeu.transform.childCount; i++) {
			Transform scriptCase = grilleDeJeu.transform.GetChild(i);
			scriptCase.GetComponent<Case>().item = SolarPut;
			Case.itemPlaced = false;
		}
		
	}
}
