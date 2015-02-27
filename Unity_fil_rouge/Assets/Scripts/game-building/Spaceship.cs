using UnityEngine;
using System.Collections;

public class Spaceship : Building {
	//Evolution batiment
	private int buildingLevel = 1;

	//Données Consommation / Production
	public Spaceship() {
		c_humain = 0;
		c_food = 10;
		c_energy = 10;
		c_water = 10;

		p_humain = 15; 
		p_food = 0;
		p_energy = 40; 
		p_water = 0;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
