﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class CtrlIUPMenu : MonoBehaviour {

	public void LoadScene(string sceneName){
		SceneManager.LoadScene(sceneName);
	}
}
