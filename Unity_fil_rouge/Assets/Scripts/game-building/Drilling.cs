using UnityEngine;
using System.Collections;

public class Drilling : Building {
	//Evolution batiment
	private int buildingLevel = 1;

	//Ressources object
	public Drilling() {
		c_humain = 10;
		c_food = 0;
		c_energy = 15;
		c_water = 0;

		p_humain = 0; 
		p_food = 0;
		p_energy = 0; 
		p_water = 60;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
