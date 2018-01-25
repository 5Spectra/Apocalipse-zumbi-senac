using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem_Auto : MonoBehaviour {

	public Mesh[] modelo_3D;
	public Material[] texturas;

	public SkinnedMeshRenderer player_skin;

	[SerializeField]
	int num;


	void LateUpdate () {

		if (Input.GetKeyDown (KeyCode.E))
			num += 1;

		if (num > texturas.Length - 1)
			num = 0;
		
		player_skin.material = texturas [num];
		player_skin.sharedMesh = modelo_3D [num];

	}
}
