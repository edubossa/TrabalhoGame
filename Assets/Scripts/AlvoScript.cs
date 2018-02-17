using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AlvoScript : MonoBehaviour {

	public static int pontos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D c) {
		print ("Alvo colidiu com " + c.gameObject.name);
		Destroy(gameObject);
		pontos++;
		print ("Qtde Pontos -> " + pontos);
		if (pontos == 4) {
			print ("Pontos zerados redirecionando para a pagina principal");
			SceneManager.LoadScene ("InicioScene");
		}
	}

}
