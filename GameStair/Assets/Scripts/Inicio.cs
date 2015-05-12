using UnityEngine;
using System.Collections;

public class Inicio : MonoBehaviour {
	
	// Declare variables
	private int clicks;
	
	// Use this for initialization
	void Start ()
	{
		clicks = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (clicks > 1)
		{
			OnMouseUp();   
		}
	}
	
	void OnMouseUp ()
	{
		Debug.Log("Usted selecciono el boton inicio!");
		Application.LoadLevel ("FirstScene");
	}
}