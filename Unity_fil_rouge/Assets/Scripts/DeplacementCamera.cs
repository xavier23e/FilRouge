using UnityEngine;
using System.Collections;

public class DeplacementCamera : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//DEPLACEMENT CAMERA
		// Création d'un nouveau vecteur de déplacement
		Vector3 move = new Vector3();
		
		//On déplace vers la droite si on est proche du bout de l'écran droite
		if (Input.mousePosition.x >= (Screen.width - 10)) {
			move.x += 0.05f;
		}
		//On déplace vers la gauche si on est proche du bout de l'écran gauche
		if (Input.mousePosition.x <= 50) {
			move.x -= 0.05f;
		}
		
		if(Input.mousePosition.y >= (Screen.height - 10)){
			move.z += 0.05f;
			
		}
		
		if(Input.mousePosition.y <= 50 ){
			move.z -= 0.05f;
			
		}
		
		
		// On applique le mouvement à l'objet
		transform.position += move;
		
		
		
	}
}
