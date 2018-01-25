using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static Material skin_material;
	public static Mesh skin_modelo;

	void Start () {
		DontDestroyOnLoad (gameObject);	
		UnityEngine.SceneManagement.SceneManager.LoadScene ("TelaSelecao");
	}

}
