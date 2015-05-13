using UnityEngine;
using System.Collections;

public class WindTurbine : Building {
	//Evolution batiment
	private int buildingLevel = 1;

	//Données Consommation / Production
	public WindTurbine(Case pCase) { 	
		c_humain = 15;
		c_food = 0;
		c_energy = 0;
		c_water = 0;

		p_humain = 0; 
		p_food = 0;
		p_energy = 40; 
		p_water = 0;

		this.caseScript = pCase;

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
