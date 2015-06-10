using UnityEngine;
using System.Collections;

public class Drilling : Building {
	//Evolution batiment
	private int buildingLevel = 1;

	public Drilling() {
		attributeValues();
	}

	//Ressources object
	public Drilling(Case pCase) {
		attributeValues();
		this.caseScript = pCase;
		addBuilding();
	}

	public void attributeValues(){
		c_humain = 10;
		//c_humain = 0;
		c_food = 0;
		c_energy = 15;
		//c_energy = 0;
		c_water = 0;
		
		p_humain = 0; 
		p_food = 0;
		p_energy = 0; 
		p_water = 60;
		//p_water = 0;
	}
}
