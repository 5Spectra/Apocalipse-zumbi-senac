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

		if (distacia > 2f){
		Vector3 direcao = jogador.transform.position - transform.position;

		GetComponent<Rigidbody> ().MovePosition (GetComponent<Rigidbody> ().position + direcao.normalized * velocidade * Time.deltaTime);

		Quaternion novaRotacao = Quaternion.LookRotation (direcao);
		GetComponent<Rigidbody> ().MoveRotation (novaRotacao);
		}
	}
}
