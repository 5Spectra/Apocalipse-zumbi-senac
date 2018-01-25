using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleBala : MonoBehaviour {

	public float Velocidade = 20;


	void Start(){
		Destroy (gameObject, 5f);
	}

	void FixedUpdate () {
		GetComponent<Rigidbody> ().MovePosition (GetComponent<Rigidbody> ().position + transform.forward * Velocidade * Time.deltaTime);
	}
}
