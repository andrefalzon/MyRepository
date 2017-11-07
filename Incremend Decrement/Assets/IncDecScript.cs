using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncDecScript : MonoBehaviour {

    int num = 50;



	// Use this for initialization
	void Start () {
        print("The number is " + num + ". ");
        print("To Increment press UP Arrow; To Decrement press DOWN Arrow");

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up"))
        {
            print("UP Arrow pressed.");
            num++;
            print("New number is " + num);
        }

        else if (Input.GetKeyDown("down"))
        {
            print("DOWN Arrow pressed.");
            num--;
            print("New number is " + num);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter is pressed!");

            UnityEditor.EditorApplication.isPlaying = false;

        }
	}
}
