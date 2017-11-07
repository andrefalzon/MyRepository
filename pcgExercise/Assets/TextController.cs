using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text myQuestion;
    public InputField myField;
    int num1 = 0;
    int num2 = 0;

    System.Random rand = new System.Random(); // the Random class found in the System Library
    Random unityRand = new Random(); //the random class found in the UnityEngine Library
    




	// Use this for initialization
	void Start () {
        StartGame();


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void GetAnswer()
    {
        int multiplactionAns = num1 * num2;

        int userAnswer = 0;
        userAnswer = System.Convert.ToInt32(myField.text); // read(get) - fetching the text

        if (userAnswer == multiplactionAns)
        {
            print("Correct answer!");
            StartGame();
        }

        else
        {
            print("Incorrect answer!");
        }
    }
        void StartGame()
        {
            myField.text = "";
            num1 = rand.Next(1, 11);// this will random a number from 1 to 10
            num2 = Random.Range(1, 11);


            myQuestion.text = "What is " + num1 + " x " + num2;
        }
    
}
