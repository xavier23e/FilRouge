using UnityEngine;
using System.Collections;

public class Recherche : MonoBehaviour {

	// Les panels pour chaque niveau de recherche de la technologie
	public GameObject level1;
	public GameObject level2;
	public GameObject level3;
	public GameObject level4;

	// Bouton ameliorer
	public GameObject btnAmeliorer;

	// Le niveau actuel de recherche
	private int currentLevel;

	// Le niveau maximum autorisé
	public const int maxLevel = 4;

	// Use this for initialization
	void Start ()
	{
		this.currentLevel = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Retourne le niveau de recherche de la technologie
	public int GetCurrentLevel ()
	{
		return this.currentLevel;
	}

	/* 	
	 * Réaction au click sur le bouton [Améliorer] 
	 * => conséquence de l'amélioration d'une technologie (meilleurs rendement, cout réduit, etc.
	 */
	public void ClickBtnAmeliorer ()
	{
		Debug.Log ("ClickBtnAmeliorer");
		if (currentLevel < maxLevel)
		{
			this.currentLevel++;
			Debug.Log("Niveau actuel: " + currentLevel);
			UpdateLevel ();
		}
	}

	/*
	 * Mise à jour de l'état de la technologie actuel (niveau)
	 */
	public void UpdateLevel ()
	{
		switch (currentLevel)
		{
			case 1:
				level1.gameObject.SetActive (true);
				level2.gameObject.SetActive (false);
				level3.gameObject.SetActive (false);
				level4.gameObject.SetActive (false);
				break;
			case 2:
				level1.gameObject.SetActive (false);
				level2.gameObject.SetActive (true);
				level3.gameObject.SetActive (false);
				level4.gameObject.SetActive (false);
				break;
			case 3:
				level1.gameObject.SetActive (false);
				level2.gameObject.SetActive (false);
				level3.gameObject.SetActive (true);
				level4.gameObject.SetActive (false);
				break;
			case 4:
				level1.gameObject.SetActive (false);
				level2.gameObject.SetActive (false);
				level3.gameObject.SetActive (false);
				level4.gameObject.SetActive (true);
				btnAmeliorer.gameObject.SetActive (false);
				break;
		}
	}
}
