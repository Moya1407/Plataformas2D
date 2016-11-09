using UnityEngine;
using System.Collections;

public class salto : MonoBehaviour {
	public float fuerza = 100f;
	public bool tocando_suelo = false;
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.UpArrow) && tocando_suelo) {
			Debug.Log ("Arriba Pulsado");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up*fuerza);
			animator.SetBool ("Salto", true);
		}
			
	}

	void OnTriggerStay2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			animator.SetBool ("Salto", false);
			tocando_suelo = true;
		}
	}
	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocando_suelo = false;
		}
	}
}