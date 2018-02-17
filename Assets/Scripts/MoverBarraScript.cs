using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBarraScript : MonoBehaviour {

	public float velocidade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moverBarra ();
	}

	void moverBarra () {

		float move_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (move_x, 0.0f, 0.0f); //Move a posicao X
		//print ("Pisicao X -> " + move_x);

	}

	void OnCollisionEnter2D(Collision2D c) {
		//print ("colidiu com --> " + c.gameObject.name);
	}

}
