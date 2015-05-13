using UnityEngine;
using System.Collections;

public class Habitation : Building {
	//Evolution batiment
	private int buildingLevel = 1;


	public Habitation(Case pCase){
		c_humain = 0;
		c_food = 10;
		c_energy = 5;
		c_water = 10;
		
		p_humain = 10; 
		p_food = 0;
		p_energy = 0; 
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
