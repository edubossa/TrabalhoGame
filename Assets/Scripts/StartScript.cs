﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton("Fire1")) {
			AlvoScript.pontos = 0;
			SceneManager.LoadScene ("GameScene");
		}
		
	}
}
