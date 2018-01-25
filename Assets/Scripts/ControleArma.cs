using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleArma : MonoBehaviour {

	public GameObject bala;
	public GameObject canoArma;

	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Instantiate (bala, canoArma.transform.position, canoArma.transform.rotation);
		}
	}
}
