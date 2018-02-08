using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GeradorZombie : MonoBehaviour {

	public GameObject Zumbie;
	public float TempoGerarZombie = 1;

	float contadorTempo = 0;

	void Start () {
		
	}

	void Update () {
		contadorTempo += Time.deltaTime;

		if (contadorTempo >= TempoGerarZombie) {
			Instantiate (Zumbie, transform.position, transform.rotation);
			contadorTempo = 0;
		}

	}
}
