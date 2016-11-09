using UnityEngine;
using System.Collections;

public class personaje : MonoBehaviour {
	public float velocidad = 5f;
	public float power = 14;
	private Animator animator;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("Velocidad",Mathf.Abs(rb.velocity.x));
		if (Input.GetKey (KeyCode.RightArrow))
		{
			rb.velocity = new Vector2 (velocidad*power,rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
	
		}

	else if (Input.GetKey(KeyCode.LeftArrow))
		{
			rb.velocity = new Vector2 (-velocidad*power,rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
		}
	}
}
