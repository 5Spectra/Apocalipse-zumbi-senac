using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin_Manager : MonoBehaviour {

	public SkinnedMeshRenderer player_skin;

	void Start () {
		player_skin.material = GameManager.skin_material;
		player_skin.sharedMesh = GameManager.skin_modelo;
	}

}
