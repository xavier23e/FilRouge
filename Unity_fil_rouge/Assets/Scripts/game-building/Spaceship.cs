using UnityEngine;
using System.Collections;

public class Spaceship : Building {
	//Evolution batiment
	private int buildingLevel = 1;

	public Spaceship() {
		attributeValues();
	}
	
	//Ressources object
	public Spaceship(Case pCase) {
		attributeValues();
		this.caseScript = pCase;
		addBuilding();
	}


	//Données Consommation / Production
	public void attributeValues() {
		c_humain = 0;
		c_food = 10;
		c_energy = 10;
		c_water = 10;

		p_humain = 15; 
		p_food = 0;
		p_energy = 40; 
		p_water = 0;
	}
}
