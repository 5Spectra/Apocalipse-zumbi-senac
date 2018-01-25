using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btns : MonoBehaviour {

	public GameObject painel_Skin, painel_Config;
	public SkinnedMeshRenderer player_skin;

	public Material[] texturas;
	public Mesh[] modelo_3D;

	bool isSkin, isConfig; 
	int skin_select;


	public void Sair (){
		Application.Quit ();
	}

	public void Troca_cena(string cena){
		UnityEngine.SceneManagement.SceneManager.LoadScene (cena);
	}

	public void OnOff_Skins(){
		if (isSkin == false) {
			painel_Skin.SetActive (true);
			painel_Config.SetActive (false);

			isSkin = true;
			isConfig = false;
		}
	}

	public void OnOff_Config(){

		if (isConfig == false) {
			painel_Config.SetActive (true);
			painel_Skin.SetActive (false);

			isConfig = true;
			isSkin = false;
		}
	}

	public void plus_skin(){
		skin_select += 1;

		if (skin_select > 21)
			skin_select = 0;

		muda_skin (skin_select);
	}

	public void minus_skin(){
		skin_select -= 1;

		if (skin_select < 0)
			skin_select = 21;

		muda_skin (skin_select);
	}

	void muda_skin(int num){
		player_skin.material = texturas [num];
		player_skin.sharedMesh = modelo_3D [num];

		GameManager.skin_material = texturas [num];
		GameManager.skin_modelo = modelo_3D [num];
	}
}
