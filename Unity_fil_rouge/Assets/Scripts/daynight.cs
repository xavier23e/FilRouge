using UnityEngine;
using System.Collections;

public class daynight : MonoBehaviour {
	public GameObject etoiles;
	public Material jourSky;
	public Material NightSky;
	public bool timeDay;
	private float timer;
	private float timerTint;
	private const float dureeDay=10f;
	private const float speedTransition=1.5f;

	// Use this for initialization
	void Start () {
		timeDay = true;
		timer = 0f;
		timerTint = 1f;
		jourSky.SetColor("_Tint",Color.grey);
		RenderSettings.skybox = jourSky;
		//RenderSettings.skybox.SetColor("_TintColor", Color.black);
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer + Time.deltaTime;

		if (timer > dureeDay ) {

			if (timeDay == false)
			{
				print("jour");
				timeDay = true;
				//RenderSettings.skybox = jourSky
				timerTint=0f;
			}
			else
			{
				timeDay=false;
				print("nuit");
				//RenderSettings.skybox = NightSky
				timerTint=0f;
			}
			timer = 0f;

		}

		//Si timeday s'active/desactive
		if (timerTint<1f){

			timerTint = timerTint + Time.deltaTime*speedTransition;

			if (timerTint>=1f){
				changeCiel();
				timerTint = 1f;
			}

			if (timeDay == false)
			{
				jourSky.SetColor("_Tint",Color.Lerp(Color.grey, Color.black, timerTint));
				//Debug.Log (timerTint);

			}
			else
			{
				NightSky.SetColor("_Tint",Color.Lerp(Color.grey, Color.white, timerTint));
			}
		}

	}

	//Si transition coleur effectue switch la texture
	void changeCiel()
	{
		Debug.Log ("changeCiel");
		if (timeDay == true)
		{
			jourSky.SetColor("_Tint",Color.grey);
			RenderSettings.skybox = jourSky;

		}
		else
		{
			NightSky.SetColor("_Tint",Color.grey);
			RenderSettings.skybox = NightSky;
		}
	}
}
