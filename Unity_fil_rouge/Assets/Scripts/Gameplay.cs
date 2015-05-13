using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour {

	//Ressources jeu
	protected int humain = 0;
	protected int food = 60;
	protected int energy = 200;
	protected int water = 30;

	public GameObject screenHumain;
	public GameObject screenFood;
	public GameObject screenEnergy;
	public GameObject screenWater;
	
	//Nombre de tour
	private int tour = 0;

	//La barre des ressources

	//Le Btn "passer" le tour


	//Mettre à jour le panneau des ressources
	public void updateScreen() {
		screenHumain.GetComponent<Text>().text = this.humain.ToString();
		screenFood.GetComponent<Text>().text = this.food.ToString();
		screenEnergy.GetComponent<Text>().text = this.energy.ToString();
		screenWater.GetComponent<Text>().text = this.water.ToString();
	}

	// Action pour chaque tour
	public void pastTour () {
		this.tour++;
		getAllBuildMap();
		updateScreen();
		verifLooseGame();
	}

	//Vérifier si nous avons perdu
	public void verifLooseGame() {
		if (this.water <= 0 || this.food <= 0 || this.energy <= 0 || this.humain <= 0) {
			Debug.Log("you loose");
		}
	}

	// parcourir tous les batiments sur la map
	public void getAllBuildMap () {


		foreach (Building item in Main.tabMapBuild)
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

	// Vérifier les ressouces pour poser un batiment
	public bool verifRessources(int res_water, int res_food, int res_energy,int res_humain){
		
		if (res_water <= this.water 
		    && res_food <= this.food
		    && res_energy <= this.energy
		    && res_humain <= this.humain) {
			return true;
		} 
		return false;
	}

}
