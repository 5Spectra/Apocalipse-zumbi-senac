using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controla_Inimigo : MonoBehaviour {

	public GameObject jogador;
	public float velocidade = 5;

	void Start () {
		velocidade = Random.Range(3,7);
	}


	void FixedUpdate () {

		float distacia = Vector3.Distance (transform.position, jogador.transform.position);

		Vector3 direcao = jogador.transform.position - transform.position;

		Quaternion novaRotacao = Quaternion.LookRotation (direcao);
		GetComponent<Rigidbody> ().MoveRotation (novaRotacao);

		if (distacia > 2f) {
			GetComponent<Rigidbody> ().MovePosition (GetComponent<Rigidbody> ().position + direcao.normalized * velocidade * Time.deltaTime);
			GetComponent<Animator> ().SetBool ("Atacando", false);
		}else {
			GetComponent<Animator> ().SetBool ("Atacando", true);
		}
	}

	void AtacaJogador(){
		Time.timeScale = 0;

		jogador.GetComponent<Jogador_Controler> ().TextoGameOver.SetActive (true);
		jogador.GetComponent<Jogador_Controler> ().Vivo = false;
	}
}
