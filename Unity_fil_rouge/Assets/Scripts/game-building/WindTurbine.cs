using UnityEngine;
using System.Collections;

public class WindTurbine : Building {
	//Evolution batiment
	private int buildingLevel = 1;

	public WindTurbine() {
		attributeValues();
	}
	
	//Ressources object
	public WindTurbine(Case pCase) {
		attributeValues();
		this.caseScript = pCase;
		addBuilding();
	}

	//Données Consommation / Production
	public void attributeValues() { 	
		c_humain = 15;
		c_food = 0;
		c_energy = 0;
		c_water = 0;

		p_humain = 0; 
		p_food = 0;
		p_energy = 40; 
		p_water = 0;
	}
}
