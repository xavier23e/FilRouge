using UnityEngine;
using System.Collections;

public class JourNuit : MonoBehaviour {
	public GameObject etoiles;
	public Material jourSky;
	public Material NightSky;
	public bool timeDay;
	private float timer;
	
	
	
	// Use this for initialization
	void Start () {
		timeDay = false;
		timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer + Time.deltaTime;
		
		if (timer > 10 ) {
			
			if (timeDay == false){
				//print("jour");
				timeDay = true;
			}
			else
			{
				timeDay=false;
				//print("nuit");
			}
			timer = 0f;
		}
		
		
		// Gestion du ciel Jour/Nuit
		if ( timeDay == false){
			RenderSettings.skybox = NightSky;
		}
		else {
			RenderSettings.skybox = jourSky;
		}
	}
}