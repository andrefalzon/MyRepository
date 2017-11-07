﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour {

    public Text compGuess;
    public Text chancesText;

    int min = 0;
    int max = 0;
    int guess = 0;
    int chances = 3;


    // Use this for initialization
    void Start () {

        StartGame();
	}
	
	// Update is called once per frame
	void Update () {

        chancesText.text = chances.ToString();

        if ()



    }

    void NextGuess()
    {
        /*
         * This Method always generates a new guess and prints it in the console Window
         */

        //guess = (min + max) / 2; // Guess is the middle value of the current range

        System.Random rand = new System.Random(); // created the copy of the Random class so that I can use its methods
        guess = rand.Next(min, (max+1)); // Next is a method which generates a random value between the specified range
        compGuess.text = guess + "?";
        chances -= 1;
    }

    void StartGame()
    {
        min = 1;
        max = 1000;

        
        NextGuess();
    }

    public void GuessHigher()
    {
        {
            min = guess  ;
            NextGuess();
        }
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }


}

