using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	private GameGridClass gameGrid;
	public GameObject caseModel;
	private GameObject caseObject;
	private int nbCase;
	
	public GameObject gameGridObject;

	// Use this for initialization
	void Start () {
		gameGrid = new GameGridClass (4, 4);

		float x = 0f;
		for (int i=0; i<gameGrid.row; i++)
		{
			float z = 0f;
			for (int j=0; j<gameGrid.column; j++)
			{
				caseObject = (GameObject) Instantiate(caseModel, new Vector3(x, 0f, z), Quaternion.identity);
				caseObject.name = "Case"+nbCase;
				caseObject.transform.parent = gameGridObject.transform;
				nbCase++;
				z++;
				//Debug.Log("x = "+x+" z = "+z);
			}
			x++;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
