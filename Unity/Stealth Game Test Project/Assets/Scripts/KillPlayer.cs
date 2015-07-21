﻿using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	public LevelManager levelManager;
	public TriesManager triesManager;


	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
		triesManager = FindObjectOfType<TriesManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
			if (other.name == "Player")
			{
				triesManager.Captured();
				levelManager.RespawnPlayer();
			}
		Debug.Log(levelManager);
	}
}