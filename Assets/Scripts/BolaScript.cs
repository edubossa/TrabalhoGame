using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BolaScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float forca;
	bool gameStarted = false;

	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if (!gameStarted) {
			gameStarted = true;
			rb.AddForce (new Vector2(forca, forca));
		}
			
	}


	void OnCollisionEnter2D(Collision2D c) {
		if (c.collider.tag == "sideDown") {
			SceneManager.LoadScene ("InicioScene");
		}
	}

}
