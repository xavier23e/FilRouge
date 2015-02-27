using UnityEngine;
using System.Collections;

public class Greenhouse : Building {
	//Evolution batiment
	private int buildingLevel = 1;

	//Données Consommation / Production
	public Greenhouse(){
		c_humain = 5;
		c_food = 0;
		c_energy = 20;
		c_water = 10;

		p_humain = 0; 
		p_food = 60;
		p_energy = 0; 
		p_water = 0;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
