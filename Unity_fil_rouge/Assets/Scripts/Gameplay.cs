using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour {

	//Ressources jeu
	protected static int humain = 10;
	protected static int food = 60;
	protected static int energy = 200;
	protected static int water = 30;

	public GameObject screenHumain;
	public GameObject screenFood;
	public GameObject screenEnergy;
	public GameObject screenWater;
	
	//Nombre de tour
	private int tour = 0;

	//Le Btn "passer" le tour

	void Awake (){
		updateScreen();
	}

	void Update() {
		updateScreen();
	}
		
	public static void calculConsommation (int pwater, int pfood, int penergy, int phumain, int pchumain ) {
		humain-= phumain;
		humain+= pchumain;
		food-= pfood;
		energy-= penergy;
		water-= pwater;
		//Debug.Log("pc : "+pchumain);
		//Debug.Log("p : "+phumain);
	}

	//Mettre à jour le panneau des ressources
	public void updateScreen() {
		screenHumain.GetComponent<Text>().text = humain.ToString();
		screenFood.GetComponent<Text>().text = food.ToString();
		screenEnergy.GetComponent<Text>().text = energy.ToString();
		screenWater.GetComponent<Text>().text = water.ToString();
	}

	// Action pour chaque tour
	public void pastTour() {
		this.tour++;
		getAllBuildMap();
		updateScreen();
		verifLooseGame();
	}

	//Vérifier si nous avons perdu
	public void verifLooseGame() {
		if (water <= 0 || food <= 0 || energy <= 0 || humain <= 0) {
			Debug.Log("you loose");
		}
	}

	// parcourir tous les batiments sur la map
	public void getAllBuildMap() {
	
		foreach (Building item in Main.tabMapBuild)
		{
			water += item.get_p_water();
			food += item.get_p_food();
			energy += item.get_p_energy();

			water -= item.get_c_water();
			food -= item.get_c_food();
			energy -= item.get_c_energy();
		}
	}

	// Vérifier les ressouces pour poser un batiment
	public bool verifRessources(int res_water, int res_food, int res_energy,int res_humain){

		if (res_water <= water 
		    && res_food <= food
		    && res_energy <= energy
		    && res_humain <= humain) {
			return true;
		} 
		return false;
	}
}
