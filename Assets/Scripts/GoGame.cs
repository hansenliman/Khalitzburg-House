﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GoGame : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
	}
}
