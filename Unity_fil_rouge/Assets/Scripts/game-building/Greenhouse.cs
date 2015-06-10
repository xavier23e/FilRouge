using UnityEngine;
using System.Collections;

public class Greenhouse : Building {
	//Evolution batiment
	private int buildingLevel = 1;


	public Greenhouse() {
		attributeValues();
	}
	
	//Ressources object
	public Greenhouse(Case pCase) {
		attributeValues();
		this.caseScript = pCase;
		addBuilding();
	}


	//Données Consommation / Production
	public void attributeValues(){
		c_humain = 5;
		c_food = 0;
		c_energy = 20;
		c_water = 10;

		p_humain = 0; 
		p_food = 60;
		p_energy = 0; 
		p_water = 0;
	}
}
