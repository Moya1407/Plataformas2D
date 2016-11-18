﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

	public int monedas = 0;
	Text texto;

	void Start(){
		texto = GetComponent<Text> ();
		resetear (); 
	}

	public void suma_monedas (int cantidad){
		monedas = monedas + cantidad; //monedas += cantidad;
		if (monedas < 0) {
			monedas = 0;
		}
		texto.text = monedas.ToString ();
	}

	public void resetear (){
		monedas = 0;
		texto.text = monedas.ToString ();
	}
}