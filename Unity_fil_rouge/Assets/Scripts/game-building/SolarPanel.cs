using UnityEngine;
using System.Collections;

public class SolarPanel : Building {
	//Evolution batiment
	private int buildingLevel = 1;

	public SolarPanel(Case pCase) {
		c_humain = 10;
		c_food = 0;
		c_energy = 0;
		c_water = 0;

		p_humain = 0; 
		p_food = 0;
		p_energy = 30; 
		p_water = 0;

		this.caseScript = pCase;
		addBuilding();
	}
	//Données Consommation / Production
		


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
