using UnityEngine;
using System.Collections;

public class SolarPanel : Building {
	//Evolution batiment
	private int buildingLevel = 1;

	public SolarPanel() {
		attributeValues();
	}
	
	//Ressources object
	public SolarPanel(Case pCase) {
		attributeValues();
		this.caseScript = pCase;
		addBuilding();
	}

	public void attributeValues() {
		c_humain = 10;
		c_food = 0;
		c_energy = 0;
		c_water = 0;

		p_humain = 0; 
		p_food = 0;
		p_energy = 30; 
		p_water = 0;
	}
}
