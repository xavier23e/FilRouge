using UnityEngine;
using System.Collections;

public class Building {

	//Données Consommation / Production
	// c_ = consommation
	// p_ = production

	protected int c_humain ;
	protected int c_food ;
	protected int c_energy ;
	protected int c_water ;
	
	protected int p_humain ;  
	protected int p_food ;
	protected int p_energy ; 
	protected int p_water ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	// get_p = get le production de l'objet
	// get_c = get la consommation de l'objet 

	public int get_p_humain(){ return this.p_humain; }
	public int get_p_food(){ return this.p_food; }
	public int get_p_energy(){ return this.p_energy; }
	public int get_p_water(){ return this.p_water; }

	public int get_c_humain(){ return this.c_humain; }
	public int get_c_food(){ return this.c_food; }
	public int get_c_energy(){ return this.c_energy; }
	public int get_c_water(){ return this.c_water; }
}
