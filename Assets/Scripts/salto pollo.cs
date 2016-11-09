using UnityEngine;
using System.Collections;

public class saltopollo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Si pulso la tecla Espacio
		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("Espacio Pulsado");
		}
	}
}
