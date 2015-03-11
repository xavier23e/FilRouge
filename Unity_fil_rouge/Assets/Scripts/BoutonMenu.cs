using UnityEngine;
using System.Collections;

public class BoutonMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter() {
		this.gameObject.transform.localScale += new Vector3(0.5F, 0.5f, 0);
	}
	void OnMouseExit() {
		this.gameObject.transform.localScale += new Vector3(-0.5F, -0.5f, 0);
	}

	void OnMouseDown()
	{
		Application.LoadLevel("FilRouge");
	}

}
