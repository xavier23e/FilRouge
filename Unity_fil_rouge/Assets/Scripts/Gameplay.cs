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

	//Panel du tutoriel
	public GameObject panelTuto;
	public GameObject textTuto;
	public static string[] tableauTxtTuto = {
		"Waouh! Quel atterrissage! \r\n" +
		"Cette planète semble viable, nous devons nous\r\nprocurer des ressources pour survivre.\r\n" +
		"Nos pilotes sont assoiffés, construis une foreuse! ",
		"Parfait! Il manque d'habitants maintenant!\r\nHate toi de construire une habitation!",
		"Nos habitants sont désormais affamés!\r\nNourris les en construisant une serre!", 
		"Tu as besoin d'energie solaire!\r\nCombine la construction de plusieurs batiments!\r\nInstalle une habitation et un panneau solaire!", 
		"Tu te débrouilles super bien!\r\nRegarde dans le menu pour voir ce qu'il te manque!\r\n!", 
		"Félicitations tu es désormais pret!\r\nEssaye de survivre le plus longtemps possible!" };


	//Nombre de tour
	public int tour = 0;

	//Le Btn "passer" le tour

	void Awake (){
		updateScreen();
		afficherTxtTuto ();
	}

	void Update() {
		updateScreen();
	}
		
	public static void calculConsommation (int pwater, int pfood, int penergy, int phumain, int pchumain ) {
		humain-= phumain;
		humain-= pchumain;
		food-= pfood;
		energy-= penergy;
		water-= pwater;
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
		if (tour < 6) {
			Debug.Log ("ici");
			afficherFenetre ();
			afficherTxtTuto ();
		}


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
			Debug.Log ("Humain : "+res_humain) ;
			return true;
		} 
		return false;
	}

	//Affiche le txt du tutoriel en fonction du nombre de tout
	public void afficherTxtTuto(){
		
		textTuto.gameObject.GetComponent<Text>().text = tableauTxtTuto [tour];
	}

	// cache la fentre de tutoriel
	public void cacherFenetre(){
		panelTuto.SetActive (false);
	}

	public void afficherFenetre(){
		panelTuto.SetActive (true);
	}
}
