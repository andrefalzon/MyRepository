using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1UIScript : MonoBehaviour {

    public Text Score1;
    

    int score1 = 0;
    




	// Use this for initialization
	void Start () {
        Score1.text = score1.ToString();	
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void IncrementOne(int num)
    {
        score1 += num;
        Score1.text = score1.ToString();
    }
}
