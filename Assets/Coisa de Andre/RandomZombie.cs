using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomZombie : MonoBehaviour {

	void Start () {

		Transform[] allChildren = GetComponentsInChildren<Transform>();

		GameObject[] skins = new GameObject[allChildren.Length];

		for (int i = 1; i < allChildren.Length; i++) {
			skins[i] = allChildren[i].gameObject;
			skins [i].SetActive (false);
		}

		skins [Random.Range (1, allChildren.Length)].SetActive (true);
	}
	

}
