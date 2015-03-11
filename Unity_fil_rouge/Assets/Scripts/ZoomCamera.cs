using UnityEngine;
using System.Collections;
public class ZoomCamera : MonoBehaviour
{
	// Public
	public float vitesseZoom = 0.2f;
	public int limiteZoom = 10;
	
	// Private
	private int _ScrollWheelminPush = 0;
	private int _ScrollCount = 5;

	void Update()
	{
		if(Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			if(_ScrollCount >= _ScrollWheelminPush && _ScrollCount < limiteZoom)
			{
				camera.transform.position += new Vector3(0, vitesseZoom, 0);
				_ScrollCount++;
			}
		}
		
		if(Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			if(_ScrollCount > _ScrollWheelminPush && _ScrollCount <= limiteZoom)
			{
				camera.transform.position -= new Vector3(0, vitesseZoom, 0);
				_ScrollCount--;
			}
		}
	}
}