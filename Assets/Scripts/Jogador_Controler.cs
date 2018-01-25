using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador_Controler : MonoBehaviour {

	public float velocidade = 10;
	Vector3 direcao;

	void Update () {
		float eixoX = Input.GetAxis ("Horizontal");
		float eixoZ = Input.GetAxis ("Vertical");

		direcao = new Vector3 (eixoX, 0,eixoZ);
		//transform.Translate (direcao * velocidade * Time.deltaTime);

		if(direcao != Vector3.zero){
			GetComponent<Animator> ().SetBool ("Movendo", true);
		}
		else{
			GetComponent<Animator> ().SetBool ("Movendo", false);
		}

	}

	void FixedUpdate(){
		
		Rigidbody movimente = GetComponent<Rigidbody>();
		movimente.MovePosition (movimente.position + (direcao * velocidade * Time.deltaTime));
	}
}
