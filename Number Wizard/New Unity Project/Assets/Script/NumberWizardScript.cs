using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int guess = 500;

    // Use this for initialization
    void Start () {
        print("Welcome to Number Wizard");
        print("Pick a number from 1 and 1000 !");


        print("Is the number higher, lower or equal to " + guess + " ?");
        print("Higher: UP arrow, Lower: DOWN arrow, Equal: Enter");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up"))
        {
            print("The up key is pressed");
            min = guess;
            guess = (min + max) / 2;
            print("Is the number higher, lower or equal to " + guess + " ?");
            print("Higher: UP arrow, Lower: DOWN arrow, Equal: Enter");

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        // if (Input.GetKeyDown("down")) 
        {
            print("The down key is pressed");
            max = guess;
            guess = (min + max) / 2;
            print("Is the number higher, lower or equal to " + guess + " ?");
            print("Higher: UP arrow, Lower: DOWN arrow, Equal: Enter");

        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("The enter key is pressed");
            print("I won!");
        }

    }
}
