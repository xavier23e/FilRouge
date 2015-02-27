using UnityEngine;
using System.Collections;

public class Gameplay : MonoBehaviour {
	//Ressources jeu
	private int humain;
	private int food = 60;
	private int energy = 200;
	private int water = 30;

	//Tableau de tout les batiments sur la carte
	private Building[] tabMapBuild = new Building[40];

	//Nombre de tour
	private int tour;

	//


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// parcourir tous les batiments sur la map
	private void getAllBuildMap () {

		foreach (Building item in tabMapBuild)
		{
			this.water += item.get_p_water();
			this.food += item.get_p_food();
			this.energy += item.get_p_energy();
			this.humain += item.get_p_humain();

			this.water += item.get_c_water();
			this.food += item.get_c_food();
			this.energy += item.get_c_energy();
			this.humain += item.get_c_humain();

		}
	}
}
