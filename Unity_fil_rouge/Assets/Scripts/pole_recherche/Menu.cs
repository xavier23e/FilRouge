using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
	public static string btnName = "";

	// Panel à afficher
	public GameObject panelToDisplay;

	// Bouton lié au panel à afficher
	public GameObject btnToDisplay;
	

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		// Si le bouton n'est pas actif, on cache le panel et le bouton [Ameliorer]
		if (btnName != gameObject.name) {
			panelToDisplay.gameObject.SetActive (false);
			btnToDisplay.gameObject.SetActive (false);
		}
	}

	public void displaySearch ()
	{
		Debug.Log("Click!");

		// On assigne le nom du gameObject attaché au script à la variable
		btnName = gameObject.name;

		// On affiche le panel de recherche assigné
		panelToDisplay.gameObject.SetActive (true);

		// On affiche le bouton lié au panel si le niveau max n'est pas atteint dans la recherche
		if (panelToDisplay.GetComponent<Recherche>().GetCurrentLevel() < Recherche.maxLevel)
		{
			btnToDisplay.gameObject.SetActive (true);
		} 
		else {
			btnToDisplay.gameObject.SetActive (false);
		}
	}

	public void DesactiverTout (GameObject[] liste) 
	{

	}
}
