using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //IMPORTANTE PARA PODER MODIFICAR ESCENAS

public class restart : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		}
	}
}
