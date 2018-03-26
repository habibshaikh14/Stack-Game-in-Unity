﻿using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
	public Text scoreText;
	
	private void Start()
	{
		scoreText.text=PlayerPrefs.GetInt("score").ToString();
	}
	
	public  void ToGame()
	{
		SceneManager.LoadScene("Game");
		
	}
}